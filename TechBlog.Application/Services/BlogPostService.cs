using TechBlog.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TechBlog.Application.Services
{
    public interface IBlogPostsService
    {
        Task<List<BlogPost>> GetAllBlogPosts();
        Task<BlogPost> AddBlogPost(BlogPost newBlogPost);
        Task<BlogPost> GetBlogPostById(int id);
        void UpdateBlogPost(int postId, string updatedPost, string updateTitle);
        void DeleteBlogPost(int postId);
    }
    public class BlogPostsService : IBlogPostsService
    {
        private List<BlogPost> _blogPosts { get; set; } = new List<BlogPost> {
            new BlogPost {
                Id = 1,
                Title = "If only C# worked in the browser",
                Post = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-30),
                ImageUrl="/img/Post1-bg.jpg"
            },
            new BlogPost {
                Id = 2,
                Title = "400th JS Framework released",
                Post = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-25)
            },
            new BlogPost {
                Id = 3,
                Title = "WebAssembly FTW",
                Post = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-20)
            },
            new BlogPost {
                Id = 4,
                Title = "Blazor is Awesome!",
                Post = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-15)
            },
            new BlogPost {
                Id = 5,
                Title = "Your first Blazor App",
                Post = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-10)
            },
        };

        public async Task<List<BlogPost>> GetAllBlogPosts()
        {
            return await Task.FromResult(_blogPosts);
        }
        public async Task<BlogPost> GetBlogPostById(int id)
        {
            var blogPost = _blogPosts.SingleOrDefault(x => x.Id == id);
            return await Task.FromResult(blogPost);
        }
        public async Task<BlogPost> AddBlogPost(BlogPost newBlogPost)
        {
            newBlogPost.Id = _blogPosts.Count + 1;
            _blogPosts.Add(newBlogPost);

            return await Task.FromResult(newBlogPost);
        }
        public void UpdateBlogPost(int postId, string updatedPost, string updateTitle)
        {
            var originalBlogPost = _blogPosts.Find(x => x.Id == postId);

            originalBlogPost.Post = updatedPost;
            originalBlogPost.Title = updateTitle;
        }

        public void DeleteBlogPost(int postId)
        {
            var blogPost = _blogPosts.Find(x => x.Id == postId);

            _blogPosts.Remove(blogPost);
        }
    }
}