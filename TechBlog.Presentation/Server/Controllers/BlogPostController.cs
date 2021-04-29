using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechBlog.Application.Services;
using TechBlog.Domain.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace TechBlog.Presentation.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogPostController : Controller
    {
        private readonly IBlogPostsService _blogPostService;
        public BlogPostController(IBlogPostsService blogPostsService)
        {
            _blogPostService = blogPostsService;
        }
        [HttpPost]
        public async Task<IActionResult> AddBlogPost(BlogPost blogPost)
        {
            var newBlogPost= await _blogPostService.AddBlogPost(blogPost);
            return Created(new Uri(Urls.BlogPost.Replace("{id}", newBlogPost.Id.ToString()), UriKind.Relative), newBlogPost);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogPost()
        {
            var allBlogPost =await _blogPostService.GetAllBlogPosts();
            if(allBlogPost is null)
            {
                return NotFound();
            }
            return Ok(allBlogPost);
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogPostById(int id)
        {
            var blogPost = await _blogPostService.GetBlogPostById(id);
            if(blogPost is null)
            {
                return NotFound();
            }
            return Ok(blogPost);

        }

        [HttpPost]
        public IActionResult UpdateBlogPost(int postId,string updatedPost,string updateTitle)
        {
            _blogPostService.UpdateBlogPost(postId,updatedPost,updateTitle);
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteBlogPost(int id)
        {
            _blogPostService.DeleteBlogPost(id);
            return Ok();
        }
    }
}