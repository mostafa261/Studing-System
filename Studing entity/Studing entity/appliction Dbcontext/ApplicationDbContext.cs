using Microsoft.EntityFrameworkCore;
using Studing_entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Studing_entity.appliction_Dbcontext
{
    internal class ApplicationDbContext : DbContext
    {
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
         modelBuilder.Entity<Blog>()
                .HasOne(e => e.header)
                .WithOne(e => e.Blog)
                .HasForeignKey<HeaderBlog>(e => e.BlogId)
                .IsRequired();
        

        modelBuilder.Entity<Blog>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Blog)
                .HasForeignKey(e => e.BlogId)
                .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Stydy;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
