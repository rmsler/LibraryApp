using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddBook(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbContext.Books;
        }

        public Book GetBookById(int BookId)
        {
            return _appDbContext.Books.FirstOrDefault(p => p.Id == BookId);
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChangesAsync();
        }
    }
}