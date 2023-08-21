using Microsoft.AspNetCore.Mvc;
using MyBlog.Sevices;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostService _postService;
        public BlogController(IPostService postService)
        {
            _postService = postService;
        }
        public ViewResult Index()
        {
            return View("Index", _postService.GetAllPosts());
        }
    }
}
