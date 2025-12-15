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

            // more LINQ Extension Methods
            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");

            var firstBook = books.First(b => b.Title == "ASP.NET MVC++");


            var returnsnullifnone = books.FirstOrDefault(b => b.Title == "ASP.NET MVC++");

            //skips the first 2 and takes 3
            var books3 = books.Skip(2).Take(3);


            var count = books.Count();


            var maxPrice = books.Max(b=> b.Price);

            var minPrice = books.Min(b=> b.Price);
            

        }
    }
}
