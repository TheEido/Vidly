using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Id = 1 ,Name = "Ahmed"},
                new Customer(){Id = 2, Name = "Mohamed"}
            };
            return View(customers);
        }

        public ActionResult Details(Customer customer)
        {
            return View(customer);
        }
    }
}