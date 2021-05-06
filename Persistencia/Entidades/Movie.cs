using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persistencia.Entidades
{
    public class Movie
    {
        [Display(Name = "Movie ID")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public int MovieId { get; set; }

        public string Title { get; set; }
        public string Director { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Gross { get; set; }
    
        public double Rating { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public String Genre { get; set; }
        public virtual Genre GenreID { get; set; }

        public virtual ICollection<ActorMovie> Characters { get; set; }
    }

}
