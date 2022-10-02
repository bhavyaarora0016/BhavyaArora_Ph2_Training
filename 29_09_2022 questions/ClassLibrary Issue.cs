using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2909Lib
{
    public class Issue
    {
        [Key]
        public int issue_id { get; set; }
        public DateTime issueDate { get; set; }


        public virtual Member member { get; set; }
        public virtual ICollection<Book> books { get; set; }

    }
}
