namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookReository().GetBooks();
            var cheapBooks = books
            .Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

            //LINQ Query Operators (always start with from and ends with select)
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            //LINQ extension methods
            foreach (var book in cheapBooks)
                //Console.WriteLine(book.Title + " " + book.Price);
                System.Console.WriteLine(book);
        }
    }
}
