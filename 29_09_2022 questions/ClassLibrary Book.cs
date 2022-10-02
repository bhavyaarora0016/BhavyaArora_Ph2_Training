using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2909Lib
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int book_no { get; set; }

        public string book_name { get; set; }
        public string author { get; set; }
        public double cost { get; set; }
        public string category { get; set; }

        public virtual Issue issue { get; set; }
    }
}
