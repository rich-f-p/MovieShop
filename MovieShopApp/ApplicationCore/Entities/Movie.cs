using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
	public class Movie
	{
		[Required]
		public int Id { get; set; }
		[Column(TypeName ="nvarchar(2084)")]
		public string? BackdropUrl { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal? Budget {  get; set; }
		[Column(TypeName = "nvarchar(MAX)")]
		[DefaultValue("")]
		public string? CreatedBy { get; set; }
		[Column(TypeName = "datetime2")]
		public DateTime? CreatedDate { get; set; }
		[Column(TypeName = "nvarchar(2084)")]
		public string? ImdbUrl {  get; set; }
		[Column(TypeName = "nvarchar(64)")]
		public string? OriginalLanguage { get; set; }
		[Column(TypeName = "nvarchar(MAX)")]
		public string? Overview { get; set; }
		[Column(TypeName = "nvarchar(2084)")]
		public string? PosterUrl { get; set; }
		[Column(TypeName = "decimal(5,2)")]
		public decimal? Price { get; set; }
		[Column(TypeName = "datetime2")]
		public DateTime? ReleaseDate { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal? Revenue { get; set; }
		public int? RunTime { get; set; }
		[Column(TypeName = "nvarchar(512)")]
		public string? Tagline { get; set; }
		[Column(TypeName = "nvarchar(256)")]
		public string? Title { get; set; }
		[Column(TypeName = "nvarchar(2084)")]
		public string? TmdbUrl { get; set; }
		[Column(TypeName = "nvarchar(MAX)")]
		[DefaultValue("")]
		public string? UpdatedBy { get; set; }
		[Column(TypeName = "datetime2")]
		public DateTime? UpdatedDate { get; set; } = DateTime.Now;



	}
}
