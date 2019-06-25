using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        // In normal MVC apps, client sends a request which is managed by the controller and then razor pages and is sent back to the client in HTML
        // In an api (Web Api here), raw data is returned

        // Benefits : it requires less server resources, less bandwidth, improving scalability and performance - the client is responsible for generating the view
        // Another name: DATA SERVICES! (we can build ASP.NET Web api for a range of view types - mobile, tablet etc) it follows the same conventions as MVC (controllers etc)
        // With ASP.NET Web Api we can also take advantage of jQuery plug ins by feeding data into the client (jQuery:DataTable)
        
        // Below we use GET/POST/PUT/DELETE this convention is known as REST

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/customers (GET returns data)
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers.Include(c => c.MembershipType);

            if (!string.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDTO>);

            return Ok(customerDtos);
        } 

        // A DTO is a plain object used to transfer data to the client or server and vice versa
        // We use it to allow us to refactor our code without breaking it (Apis should never recieve or send objects)
        // We also have security problems as the hacker has direct access to our domain objects

        // GET /api/customers/id

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDTO>(customer));
        }

        // POST /api/customers (CREATES data)
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDTO customerDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDTO, Customer>(customerDTO);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDTO.Id = customer.Id;

            // Here we return the URI (Unified Resource Identifier - it unambiguously defines a resource via a string) api/customers/id
            // new Uri(Request.RequestUri (api/controller) + "/" + id), fooDto) < we need to pass the object that was created as an arguement - fooDto
            // This will return a 201 code, which conforms to RESTful convention
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDTO);
        }

        // PUT /api/customer/id (UPDATES data)
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDTO customerDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDTO, customerInDb);

            _context.SaveChanges();
        }

        // DELETE /api/customers/1 (DELETES DATA)
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
