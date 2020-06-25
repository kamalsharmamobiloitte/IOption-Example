﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOptionDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IOptionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blogController : ControllerBase
    {
        public IActionResult Get()
        {
            var blogs = new List<Blog>();
            var blogPosts = new List<BlogPost>();

            blogPosts.Add(new BlogPost
            {
                Title = "Content negotiation in .NET Core",
                MetaDescription = "Content negotiation is one of those quality-of-life improvements you can add to your REST API to make it more user-friendly and flexible. And when we design the API, isn't that what we want to achieve in the first place?",
                Published = true
            });

            blogs.Add(new Blog()
            {
                Name = "Code Maze",
                Description = "A practical programmers resource",
                BlogPosts = blogPosts
            });

            return Ok(blogs);
        }
    }

     
}