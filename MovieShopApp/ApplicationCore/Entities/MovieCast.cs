using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
	[PrimaryKey(nameof(CastId), nameof(Character),nameof(MovieId))]
	public class MovieCast
	{
		[Required]
		public int CastId { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(450)")]
		public string Character {  get; set; }
		[Required]
		public int MovieId { get; set; }

		public Movie Movies { get; set; }
		public Cast Casts { get; set; }
	}
}
