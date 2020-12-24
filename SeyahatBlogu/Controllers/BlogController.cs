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

        public ActionResult BlogDetay(int id)
        {
            var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}