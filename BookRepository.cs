namespace Linq
{
    public class BookReository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>{
    new Book() {Title = "ADO.net step by step", Price=5},
    new Book() {Title = "ADO.net step by step", Price=7},
    new Book() {Title = "c#", Price=8}
};
        }


    }
}