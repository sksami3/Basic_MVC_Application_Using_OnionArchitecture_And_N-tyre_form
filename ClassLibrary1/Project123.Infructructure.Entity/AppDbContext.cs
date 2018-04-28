using Project123.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Project123.Infructructure.Entity
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {

        }
        public DbSet<UserAccountModel> useraccountmodel { set; get; }
    }
}
