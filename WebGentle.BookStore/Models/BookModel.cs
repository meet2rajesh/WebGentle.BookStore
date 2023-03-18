namespace WebGentle.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        
        //[StringLength(100, MinimumLength = 5)]
        //[Required(ErrorMessage = "Please enter the title of your book")]

        public string Title { get; set; }
        
        //[Required(ErrorMessage = "Please enter the author name")]
        public string Author { get; set; }


    }
}
