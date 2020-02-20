using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Author
    {
        [Key]
        public int Aid { get; set; }
        public string Aname { get; set; }
        public string Address { get; set; }
        public List<Book> books { get; set; }

        public static implicit operator Author(int v)
        {
            throw new NotImplementedException();
        }
    }
}
