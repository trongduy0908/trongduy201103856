using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trongduy201103856.Models;
using trongduy201103856.ViewModels;

namespace trongduy201103856.Controllers
{
    public class CouresController : Controller
        private readonly ApplicationDbContext_dbContext;
        public CoursesController()
    {
        _dbContext = new ApplicationDbContext();
    }
    {
        // GET: Coures
        public ActionResult Create()
        {
        var viewModel = new CourseViewModel
        {
            Categories = _dbContext.Categories.Tolist()
        };
            return View(viewModel);
        }
    }
}