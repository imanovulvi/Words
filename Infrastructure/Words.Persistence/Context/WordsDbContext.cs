using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Entitys.Entitys;

namespace Words.Persistence.Context
{
    public class WordsDbContext:DbContext
    {
        public WordsDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Entry> Entries { get; set; }
        public DbSet<EmailConfirmation> EmailConfirmations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            OnBeforeSave();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        public void OnBeforeSave() 
        {
            var ls = ChangeTracker.Entries().Where(x => x.State == EntityState.Added).Select(x => (BaseEntity)x.Entity);
            foreach (var item in ls)
            {
                item.CreateDate= DateTime.Now;
            }
        }


    }
}
