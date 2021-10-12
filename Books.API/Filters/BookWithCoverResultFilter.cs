using AutoMapper;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Books.API.ExternalModels;

namespace Books.API.Filters
{
    public class BookWithCoverResultFilter : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(
           ResultExecutingContext context,
           ResultExecutionDelegate next)
        {

            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value == null
                || resultFromAction.StatusCode < 200
                || resultFromAction.StatusCode >= 300)
            {
                await next();
                return;
            }

            //var (book, bookCovers) = ((Entities.Book book, 
            //    IEnumerable<ExternalModels.BookCover> bookCovers))resultFromAction.Value;

            //var temp = ((Entities.Book, 
            //    IEnumerable<ExternalModels.BookCover>))resultFromAction.Value;

            var (book, bookCovers) = ((Data.Entities.Book,
                IEnumerable<ExternalModels.BookCover>))resultFromAction.Value;

            var mapper = context.HttpContext.RequestServices.GetRequiredService<IMapper>();

            var mappedBook = mapper.Map<BookCover>(book);
            resultFromAction.Value = mapper.Map(bookCovers, mappedBook);

            await next();
        }

    }
}
