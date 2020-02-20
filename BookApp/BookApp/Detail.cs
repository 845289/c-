using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Detail
    {
        [Key]
        public int id { get; set; }
        public int Aid { get; set; }
        public int bid { get; set; }
        public virtual Book book { get; set; }
        public virtual Author author { get; set; }
    }
}
