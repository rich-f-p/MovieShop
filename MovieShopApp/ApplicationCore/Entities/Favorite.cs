using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
	[PrimaryKey(nameof(MovieId), nameof(UserId))]
	public class Favorite
	{
		[Required]
		public int MovieId { get; set; }
		[Required]
		public int UserId { get; set; }
	}
}
