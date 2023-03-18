using Microsoft.AspNetCore.Mvc;
using WebGentle.BookStore.Models;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
             _bookRepository =new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            //return "Get All books";
            //return _bookRepository.GetAllBooks();

            var data= _bookRepository.GetAllBooks();
            
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }


        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            // return $"Book with Name = {bookName} & Author={authorName}";

            return _bookRepository.SearchBooks(bookName, authorName);
        }


    }
}
