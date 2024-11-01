using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class AddMovieModel
    {
        public string? BackdropUrl { get; set; }
        public decimal? Budget { get; set; }
        [DefaultValue("")]
        public string? ImdbUrl { get; set; }
        [Required(ErrorMessage = "Please input a Language.")]
        public string? OriginalLanguage { get; set; }
        [Required(ErrorMessage = "Please input overview.")]
        public string? Overview { get; set; }
        [Required(ErrorMessage = "Please provide a poster.")]
        public string? PosterUrl { get; set; }
        [Required(ErrorMessage = "Please input a price.")]
        public decimal? Price { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? Revenue { get; set; }
        public int? RunTime { get; set; }
        public string? Tagline { get; set; }
        [Required(ErrorMessage = "Please input a title.")]
        public string Title { get; set; }
        public string? TmdbUrl { get; set; }
    }
}
