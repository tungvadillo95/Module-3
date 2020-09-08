using BlogManagement.Models.Entity;
using BlogManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Services
{
   public interface IPostService
    {
        Post GetPost(int ID);
        int CreatePost(Post post);
        IEnumerable<RegisterPostView> GetPosts(int blogId);
        int UpdatePost(RegisterPostView model);
        int DeletePost(int id);
    }
}
