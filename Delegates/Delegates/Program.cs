using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Declare delegate
    public delegate void DoSomethingWithBook(Book book);

    public class Book
    {
        public Book(string title, string author, int price, bool papaerback)
        {
            Title = title;
            Author = author;
            Price = price;
            Paperback = papaerback;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool Paperback { get; set; }
    }

    class BookDataBase
    {
        List<Book> listOfBooks = new List<Book>();

        public void AddBook(string title, string author, int price, bool paperback)
        {
            listOfBooks.Add(new Book(title, author, price, paperback));
        }
        public void ProcessBooks(DoSomethingWithBook process)
        {
            foreach (Book b in listOfBooks)
            {
                process(b);
            }
        }
    }

    class PriceCounter
    {
        int booksCount = 0;
        int priceTotal = 0;
        Dictionary<string, int> prices = new Dictionary<string, int>();

        public void AddBookToTotal(Book book)
        {
            booksCount++;
            priceTotal += book.Price;
        }
        public int AvaragePrice()
        {
            return priceTotal / booksCount;
        }

        public void GetPrice(Book book)
        {
            prices.Add(book.Title, book.Price);
        }

        public void PrintPrices()
        {
            foreach (KeyValuePair<string, int> price in prices)
            {
                Console.WriteLine("Title: {0}, Price: {1}", price.Key, price.Value);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BookDataBase db = new BookDataBase();
            List<Book> list = new List<Book>();

            db.AddBook("alice", "Carrol", 10, true);
            db.AddBook("lotr", "Tolkien", 15, true);
            db.AddBook("game of thrones", "Martin", 20, true);
            db.AddBook("kolobok", "unknown", 30, true);

            //db.ProcessBooks(PrintTitle);

            PriceCounter totaller = new PriceCounter();
            //db.ProcessBooks(totaller.AddBookToTotal);

            //Console.WriteLine(totaller.AvaragePrice());

            db.ProcessBooks(totaller.GetPrice);

            totaller.PrintPrices();

            Console.ReadLine();
        }

        static void PrintTitle(Book book)
        {
            Console.WriteLine(book.Title);
        }
    }
}
