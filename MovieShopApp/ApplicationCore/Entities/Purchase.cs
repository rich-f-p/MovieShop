using ApplicationCore.Models;
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
	[PrimaryKey(nameof(MovieId), nameof(UserId))]
	[Index (nameof(PurchaseNumber), IsUnique =true)]
	public class Purchase
	{
		[Required]
		public int MovieId { get; set; }
		[Required]
		public int UserId { get; set; }
		[Required]
		[Column(TypeName = "datetime2")]
		[PurchaseDateValidation]
		public DateTime PurchaseDateTime { get; set; }
		[Required]
		public string PurchaseNumber { get; set; }
		[Required]
		[Column(TypeName = "decimal(5,2)")]
		public decimal TotalPrice { get; set; }
	}
}
