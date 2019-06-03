using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }
        [Required]

        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        public string OperationType {
            get
            {
                return Id != 0 ? "Edit movie" : "New movie";
            }
        }

        public MoviesFormViewModel()
        {
            Id = 0;
        }

        public MoviesFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}