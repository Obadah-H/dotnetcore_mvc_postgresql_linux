using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcore_mvc_postgresql_linux.Models;

namespace dotnetcore_mvc_postgresql_linux.Controllers
{
    public class ArticleController : Controller
    {
        private DataContext _context = null;
        public ArticleController(DataContext context)
        {
            _context = context;
        }

[HttpGet]
        public IActionResult GetArticles()
        {
            return View();
        }

    }
}
