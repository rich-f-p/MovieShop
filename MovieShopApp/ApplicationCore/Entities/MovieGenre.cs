using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
	[PrimaryKey(nameof(GenreId), nameof(MovieId))]
	public class MovieGenre
	{
		[Required]
		public int GenreId { get; set; }
		[Required]
		public int MovieId { get; set; }
	}
}
