using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Entitys.Entitys;

namespace Words.Persistence.Configuration
{
    public class EntryConfiguration:BaseConfiguration<Entry>
    {
        public override void Configure(EntityTypeBuilder<Entry> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.User).WithMany(x => x.Entries).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Comments).WithOne(x => x.Entry).HasForeignKey(x => x.EntryId);
            builder.HasMany(x => x.Favorites).WithOne(x => x.Entry).HasForeignKey(x => x.EntryId);
            builder.HasMany(x => x.Votes).WithOne(x => x.Entry).HasForeignKey(x => x.EntryID);

            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Content).IsRequired();
                
                
        }
    }
}
