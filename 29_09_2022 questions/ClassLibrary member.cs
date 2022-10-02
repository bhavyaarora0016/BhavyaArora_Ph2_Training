using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2909Lib
{
    public class Member
    {
        public int member_id { get; set; }
        [Key,ForeignKey("Issue")]

        public int issue_id { get; set; }

        public string member_name { get; set; }
        public DateTime acc_opendate { get; set; }

        public double penalty_amount { get; set; }
        public virtual Issue issue { get; set; }
    }
}
