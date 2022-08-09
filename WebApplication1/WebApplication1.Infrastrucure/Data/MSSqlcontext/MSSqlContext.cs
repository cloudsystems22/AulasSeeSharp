using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Infrastrucure.Data.MSSqlcontext
{
    public class MSSqlContext : DbContext
    {
        public MSSqlContext()
        {

        }

        public MSSqlContext(DbContextOptions<MSSqlContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Product> Product { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateAt").CurrentValue = DateTime.Now;
                    entry.Property("UpdateAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdateAt").CurrentValue = DateTime.Now;
                    entry.Property("CreateAt").IsModified = false;
                }

            }
            return base.SaveChanges();
        }

    }

}
