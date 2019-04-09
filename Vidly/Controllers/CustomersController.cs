using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers;

        public CustomersController()
        {
            _customers = new List<Customer>
            {
                new Customer { Id = 5, Name = "Bob Wilson"},
                new Customer { Id = 6, Name = "Alan Smith"},
                new Customer { Id = 7, Name = "Anders Limpar"}
            };
        }
        // GET: Customers
        public ActionResult ViewCustomers()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = _customers
            };                        

            return View(viewModel);
        }

        public ActionResult ViewIndividualCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);

            if (customer != null)
                return View(customer);
            else
                return View();            
        }
    }
}