using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository

{
    public class BookRepository
    {
          
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
            //return DataSource().where(x => x.title == title && x.author == authorName).tolist();

        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title = "Java", Author = "Rajesh" },
                 new BookModel(){Id=2, Title = ".Net", Author = "Deepak" },
                  new BookModel(){Id=3, Title = "MVC", Author = "Neha" },
                   new BookModel(){Id=4, Title = "Spring", Author = "Sachi" },
                    new BookModel(){Id=5, Title = "SQL", Author = "Amit" }
                     
                    };
              }

    }
}
