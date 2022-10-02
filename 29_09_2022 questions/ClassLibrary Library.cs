using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2909Lib
{
    public class Library : DbContext
    {
        public Library() : base()
        {
            Database.SetInitializer<Library>(new DropCreateDatabaseIfModelChanges<Library>());

        }

        public virtual DbSet<Book> books { get; set; }
        public virtual DbSet<Member> members { get; set; }
        public virtual DbSet<Issue> issues { get; set; }
    }
}
