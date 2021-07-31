using Library.Db.Entitties;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Db
{
    public class MainContext : DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options) { }

        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbBooks> Books { get; set; }
        public DbSet<DbAuthors> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbUser>()
                .HasQueryFilter(p => p.DeletedAt == null)
                .HasMany(s => s.Books)
                .WithOne(s => s.User);

            modelBuilder.Entity<DbAuthors>();
        }
    }
}
