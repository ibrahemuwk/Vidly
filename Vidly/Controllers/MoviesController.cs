using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

       public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

       protected override void Dispose(bool dispose)
       {
            _context.Dispose();
       }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "ibrahim"
            };
           var customers = _context.Customers.ToList();
            var viewModel = new RandomViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customers = _context.Customers.ToList();
            var name = customers.Where(e => e.Id == id).ToList();
            var customer = name[0];
            //customer.Name = name.ToString();

            return View(customer);
        }

      
        
    }
}