using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy.Models;
using Udemy.ViewModels;

namespace Udemy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer  { Name = "Customer 1" },
                new Customer  { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                Customers = customers
            };

            return View(viewModel); 
        }

        public ContentResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";


            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/ {month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }

   
}