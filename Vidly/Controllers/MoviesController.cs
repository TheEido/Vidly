using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Ahmed Eid" };
            return View(movie);
        }
        public ActionResult Edit(int movieId)
        {
            return Content("movieId = " + movieId);
        }

        [Route("Movies/Released/{year:regex(\\d{4}):range(2000,2021)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult Released(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}