﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.API.Services
{
    public interface IBooksRepository
    {
        //IEnumerable<Entities.Book> GetBooks();

        //Entities.Book GetBook(int id);

        Task<IEnumerable<Entities.Book>> GetBooksAsync();

        Task<Entities.Book> GetBookAsync(int id);
    }
}