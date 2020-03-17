using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace core_basic.Models
{
    public class BookCategory
    {
        public List<Book> Books { get; set; }
        public SelectList Categories { get; set; }
        public string Bookcategory { get; set; }
        public string searchstr { get; set; }
        public SelectList publisher { get; set; }
        public string Publishersear { get; set; }

       
    }
}
