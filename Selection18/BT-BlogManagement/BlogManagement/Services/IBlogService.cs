using BlogManagement.Models.Entity;
using BlogManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Services
{
    public interface IBlogService
    {
        Blog GetBlog(int ID);
        int CreateBlog(Blog blog);
        IEnumerable<RegisterBlogView> GetBlogs();
        int UpdateBlog(RegisterBlogView model);
        int DeleteBlog(int id);
        IEnumerable<RegisterUserView> GetUsers();
        int CreateUser(User user);
    }
}
