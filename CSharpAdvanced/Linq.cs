namespace CSharpAdvanced;

public static class Linq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Linq");

        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(2, 3));

        Console.WriteLine("Finish -> Linq");
    }
}
