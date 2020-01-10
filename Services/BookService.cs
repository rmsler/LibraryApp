using Library2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void ChangeStateById(int bookId)
        {
            var book = _bookRepository.GetBookById(bookId);
            book.State = !book.State;
            _bookRepository.SaveChanges();
        }
    }
}
