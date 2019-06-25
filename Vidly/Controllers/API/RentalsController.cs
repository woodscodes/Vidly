using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(RentalDTO rental)
        {         
            var customer = _context.Customers.SingleOrDefault(c => c.Id == rental.CustomerId);
            
            var movies = _context.Movies.Where(m => rental.MovieIds.Contains(m.Id)).ToList();

            /* My solution, I think technically this would work, but a problem would be that from a performance point of view it would make multiple calls to the database to create the rentals
            foreach (var movieId in rental.MovieIds)
            {
                var rentalToAdd = new Rental { Customer = customer, Movie = _context.Movies.SingleOrDefault(m => m.Id == movieId), DateRented = DateTime.Now, DateReturned = null };
                _context.Rentals.Add(rentalToAdd);
            }*/

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rentalToAdd = new Rental
                {
                    Customer = customer,
                    Movie = movie,                    
                    DateRented = DateTime.Now
                };
                
                _context.Rentals.Add(rentalToAdd);
            }
            
            _context.SaveChanges();
            return Ok();
        }
    }
}
