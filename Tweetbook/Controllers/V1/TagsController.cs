using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tweetbook.Contracts.V1;
using Tweetbook.Services;

namespace Tweetbook.Controllers.V1
{
    public class TagsController : Controller
    {
        private readonly IPostService _postService;

        public TagsController(IPostService postService)
        {
            _postService = postService;
        }
        
        [HttpGet(ApiRoutes.Tags.GetAll)]
        [Authorize(Policy="TagViewer")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _postService.GetAllTagsAsync());
        }
    }
}