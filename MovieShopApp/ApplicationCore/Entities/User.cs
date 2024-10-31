using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
	public class User
	{
		public int Id { get; set; }
        [Required(ErrorMessage = "Birth Date Required")]
        [Column(TypeName ="datetime2")]
		public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Email Required")]
        [Column(TypeName = "nvarchar(256)")]
		public string Email { get; set; }
        [Required(ErrorMessage = "First Name Required")]
        [Column(TypeName = "nvarchar(128)")]
		public string FirstName { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [Column(TypeName = "nvarchar(1024)")]
		public string HashedPassword { get; set; }
		public int? IsLocked { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        [Column(TypeName = "nvarchar(128)")]
		public string LastName { get; set; }
		[Column(TypeName = "nvarchar(16)")]
		public string? PhoneNumber { get; set; }
		[Column(TypeName = "nvarchar(MAX)")]
		public string? ProfilePictureUrl { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(1024)")]
		public string? Salt { get; set; } = "salt";

		public ICollection<Favorite> Favorites { get; set; }
		public ICollection<Purchase> Purchases { get; set; }
		public ICollection<Review> Reviews { get; set; }
		public ICollection<UserRole> UserRoles { get; set; }
	}
}
