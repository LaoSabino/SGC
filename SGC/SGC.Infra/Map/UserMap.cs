using SGC.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.Infra.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.Id);
            //properties             
            Property(t => t.Name).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(t => t.Email).HasMaxLength(100).HasColumnType("varchar");
            Property(t => t.Login).HasMaxLength(100).HasColumnType("varchar");
            Property(t => t.Password).HasMaxLength(100).HasColumnType("varchar");

            //table  
            ToTable("Users");

        }
    }
}
