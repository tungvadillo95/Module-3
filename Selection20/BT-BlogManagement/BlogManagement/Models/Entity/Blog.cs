using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Models.Entity
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string Present { get; set; }
        public CategoryBlog Category { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
