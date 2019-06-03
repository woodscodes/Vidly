using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [Display(Name="Genre")]
        public string Name { get; set; }

    }
}