using System.ComponentModel;
using System.Linq;
using dotnetcore_mvc_postgresql_linux.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_mvc_postgresql_linux.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController: ControllerBase
    {
        private BloggingContext _context = null;

        public ArticleController(BloggingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetArticles()
        {
            return Ok(_context.Articles.ToList());
        }
    }
}