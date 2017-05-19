using SGC.Core;
using SGC.Infra.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.Infra
{
    public class DBBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DBBaseContext() : base("conexsgc")
        {

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }


    }
}

