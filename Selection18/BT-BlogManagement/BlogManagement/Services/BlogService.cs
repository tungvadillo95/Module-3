using BlogManagement.Models;
using BlogManagement.Models.Entity;
using BlogManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Services
{
    public class BlogService : IBlogService
    {
        private readonly BloggingContext context;

        public BlogService(BloggingContext context)
        {
            this.context = context;
        }

        public int CreateBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            return context.SaveChanges();
        }

        public int CreateUser(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges();
        }

        public int DeleteBlog(int id)
        {
            var deleteBlog = GetBlog(id);
            if (deleteBlog != null)
            {
                context.Blogs.Remove(deleteBlog);
                return context.SaveChanges();
            }
            return -1;
        }

        public Blog GetBlog(int ID)
        {
            return context.Blogs.FirstOrDefault(b => b.BlogId == ID);
        }

        public IEnumerable<RegisterBlogView> GetBlogs()
        {
            IEnumerable<RegisterBlogView> blogs = new List<RegisterBlogView>();
            blogs = (from b in context.Blogs
                     select (new RegisterBlogView()
                     {
                         Id = b.BlogId,
                         BlogName = b.BlogName,
                         Present = b.Present,
                         Category=b.Category
                     }));
            return blogs;
        }

        public IEnumerable<RegisterUserView> GetUsers()
        {
            IEnumerable<RegisterUserView> users = new List<RegisterUserView>();
            users = (from u in context.Users
                     select (new RegisterUserView()
                     {
                         UserId=u.UserId,
                         Username=u.Username,
                         Password=u.Password
                     }));
            return users;
        }

        public int UpdateBlog(RegisterBlogView model)
        {
           var blog = GetBlog(model.Id);
            if(blog == null)
            {
                return -1;
            }
            blog.BlogName = model.BlogName;
            blog.Present = model.Present;
            blog.Category = model.Category;
            context.Update(blog);
            return context.SaveChanges();
        }
    }
}
