using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Db
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("UniContext") { }
        public DbSet<User> Users { get; set; }

    }
}
