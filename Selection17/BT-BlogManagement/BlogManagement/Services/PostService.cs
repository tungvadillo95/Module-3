using BlogManagement.Models;
using BlogManagement.Models.Entity;
using BlogManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Services
{
    public class PostService : IPostService
    {
        private readonly BloggingContext context;

        public PostService(BloggingContext context)
        {
            this.context = context;
        }
        public int CreatePost(Post post)
        {
            context.Posts.Add(post);
            return context.SaveChanges();
        }

        public int DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterPostView> GetPosts(int blogId)
        {
            IEnumerable<RegisterPostView> posts = new List<RegisterPostView>();
            posts = (from p in context.Posts
                     join b in context.Blogs on p.BlogId equals b.BlogId
                     select (new RegisterPostView()
                     {
                        PostId=p.PostId,
                        BlogId=p.BlogId,
                        Title=p.Title,
                        Content=p.Content,
                        DateUpload=p.DateUpload
                     }));
            return posts;
        }

        public int UpdatePost(RegisterPostView model)
        {
            throw new NotImplementedException();
        }
    }
}
