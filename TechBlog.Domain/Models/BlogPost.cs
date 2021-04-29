using System;

namespace TechBlog.Domain.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public string Post { get; set; }
        public string PostSummary
        {
            get
            {
                if (Post.Length > 100)
                    return Post.Substring(0, 100);

                return Post;
            }
        }
        public string ImageUrl { get; set; }
    }
}