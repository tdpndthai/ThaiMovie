using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThaiMovie.Models;
using ThaiMovie.ViewModels;

namespace ThaiMovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Detail()
        {
            return View();
        }


        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Thai", Id = 9 };
            //ViewData["RandomMovie"] = movie;
            //ViewBag.RandomMovie = movie;
            var customer = new List<Customer>
            {
                new Customer{Name="ct1"},
                new Customer{Name="ct2"},
                new Customer{Name="ct3"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModel);
        }

        //public ActionResult Random()
        //{
        //    Movie movie = new Movie() { Name = "Thai", Id = 9 };
        //    //return View(movie);
        //    return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content("id" + id);
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue) //kiểm tra có giá trị toán tử ở đây không
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy)) //chuỗi trống hoặc trắng thông tin
        //        sortBy = "Name";
        //    return Content(string.Format("pageIndex={0}&sortBy{1}",pageIndex,sortBy));
        //}
        //[Route("movies/release/{year}/{month:regex(\\d{4}):range(1, 12)}")] //biểu thức chính quy này không phải 1 chuỗi nên phải lặp lại gạch chéo 2 lần
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+"/"+month);
        //}
    }

}