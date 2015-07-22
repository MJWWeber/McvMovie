using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace McvMovie.Models
{
    public class Movies
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)] //added 7/22
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //added 7/22
        [Required] //added 7/22
        [StringLength(30)] //added 7/22
        public string Genre { get; set; }

        [Range(1, 100)]  //added 7/22
        [DataType(DataType.Currency)] //added 7/22
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //added 7/22
        [StringLength(5)] //7/22
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
    }
}