using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using core_basic.DataLayer;
using Microsoft.Extensions.DependencyInjection;

namespace core_basic.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        Btitle = "shunt",
                        Category = "Drama",
                        Price = 100.00,
                        AuthorName = "dharsh",
                        Publisher = "penguin",
                        Releasedate = Convert.ToDateTime("10-5-2013")
                    },
                new Book
                {
                    Btitle = "adventures of huckleberry finn ",
                    Category = "Adventure",
                    Price = 100,
                    AuthorName = "Mark Twain",
                    Publisher = "penguin",
                    Releasedate = Convert.ToDateTime("10-5-1888")
                });
                context.SaveChanges();
            }
        }
    }
}
