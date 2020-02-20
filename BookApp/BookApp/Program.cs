using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Program
    {
        public static void insertinitialdata()
        {
            Context c = new Context();
            var authors = new List<Author>
            {
                new Author{Aname="ravinder singh",Address="punjab"},
                new Author{Aname="amish tripati",Address="mumbai"},
                new Author{Aname="roald dahl",Address="england"},
                new Author{Aname="gillian flynn",Address="america"},

            };
            authors.ForEach(s => c.Authors.Add(s));
            c.SaveChanges();
           // Book b = new Boo
            var books = new List<Book>
            {
                new Book{ title="mahabharat",price=123,Aid=1},
                new Book{ title="alchemist",price=103},
                new Book{ title="kanya sulkam",price=500},
                new Book{ title="maha prasthanam",price=121},
                new Book{ title="gone girl",price=129},
                new Book{ title="norweign wood",price=908},

            };
            books.ForEach(p => c.books.Add(p));
            c.SaveChanges();
            var details = new List<Detail>
            {
                new Detail{ Aid=1,bid=2},
                new Detail{ Aid=2,bid=1},
                new Detail{ Aid=3,bid=2},
                new Detail{ Aid=3,bid=3},


            };
            details.ForEach(n => c.details.Add(n));
            c.SaveChanges();

        }
        public static void show()
        { 
        Context ct = new Context();
        var authors = ct.Authors;
        Console.WriteLine("Author details");
foreach (var p in authors)
{
Console.WriteLine("{0}\t{1}\t{2}", p.Aid, p.Aname, p.Address);
}
    var books = ct.books;
    Console.WriteLine("Book details");
foreach (var p in books)
{
Console.WriteLine("{0}\t{1}\t{2}", p.bid, p.title, p.price);
}
var details = ct.details;
Console.WriteLine(" details");
Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", "dtid", "bid", "name", "price", "aid", "name", "address");
foreach (var p in details)
{
Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", p.id, p.bid, p.book.title, p.book.price, p.Aid, p.author.Aname, p.author.Address);
}
}


        static void Main(string[] args)
        {
           // insertinitialdata();
           show();

        }
    }
}
