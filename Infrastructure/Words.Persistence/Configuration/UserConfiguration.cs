using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Entitys.Entitys;

namespace Words.Persistence.Configuration
{
    public class UserConfiguration:BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=>x.Favorites).WithOne(x=>x.User).HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Votes).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Comments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
