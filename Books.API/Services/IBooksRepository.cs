using Books.API.ExternalModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.API.Services
{
    public interface IBooksRepository
    {
        IEnumerable<Data.Entities.Book> GetBooks();

        //Entities.Book GetBook(int id);

        Task<IEnumerable<Data.Entities.Book>> GetBooksAsync();

        Task<Data.Entities.Book> GetBookAsync(int id);

        Task<IEnumerable<Data.Entities.Book>> GetBooksAsync(IEnumerable<int> bookIds);

        Task<BookCover> GetBookCoverAsync(string coverId);

        Task<IEnumerable<BookCover>> GetBookCoversAsync(int bookId);

        void AddBook(Data.Entities.Book bookToAdd);

        Task<bool> SaveChangesAsync();
    }
}
