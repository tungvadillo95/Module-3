using BlogManagement.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Models
{
    public class BloggingContext : IdentityDbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
                .HasOne<Blog>(v => v.Blog)
                .WithMany(b => b.Posts)
                .HasForeignKey(p => p.BlogId);
            //modelBuilder.Ignore<Blog>();
            //modelBuilder.Ignore<Post>();
            //modelBuilder.Ignore<User>();
        }         
    }
}
