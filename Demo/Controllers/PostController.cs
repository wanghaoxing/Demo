using AutoMapper;
using Core.Entities;
using Core.Entities.Dtos;
using Infrastructure.DateBase;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/Post")]
    public class PostController:Controller
    {
        //private readonly MyContext _myContext;
        private readonly IPostService _postService;
        private readonly ILogger<PostController> _logger;
        private readonly IMapper _imapper;
        public PostController(IPostService postService,
            ILogger<PostController> logger,
            IMapper iMapper)
        {
            _postService = postService;
            _logger = logger;
            _imapper = iMapper;
        }
        public async Task<IActionResult> Get()
        {
            var post = await _postService.GetAllPostsAsync();
            var postdto = _imapper.Map<IEnumerable<Post>, IEnumerable<PostDto>>(post);
            _logger.LogError("测试日志");
            return Ok(postdto);
        }
    }
}
