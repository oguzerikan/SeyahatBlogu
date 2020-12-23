using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SeyahatBlogu.Models.Siniflar;
using System.Web.Mvc;

namespace SeyahatBlogu.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
    }
}