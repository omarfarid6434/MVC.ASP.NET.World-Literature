using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using MVC.ASP.NET.World_Literature.Models;

namespace MVC.ASP.NET.World_Literature.Controllers
{
    public class StoriesController : Controller
    {
        // GET: Stories

        private ApplicationDbContext _context;

        public StoriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
           var stories = _context.Stories.ToList();

            return View(stories);
        }

        public ActionResult Details(int id)
        {
            var storie = _context.Stories.SingleOrDefault(c => c.Id == id);

            if (storie == null)
                return HttpNotFound();

            return View(storie);
        }
    }
}