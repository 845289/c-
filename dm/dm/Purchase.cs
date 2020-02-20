using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dm
{
    class Purchase
    { 
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
        public virtual Customer customer { get; set; }
        public virtual Product product { get; set; }

    }
}
