using System.ComponentModel.DataAnnotations;

namespace AuthenticationJwt.Model
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "First Name is required.")]
		[MaxLength(30, ErrorMessage = "Maximum length is 30 characters.")]
		public string? FirstName { get; set; }

		[Required(ErrorMessage = "Last Name is required.")]
		[MaxLength(30, ErrorMessage = "Maximum length is 30 characters.")]
		public string? LastName { get; set; }

		public string? Email { get; set; }

		public byte[] PasswordHash { get; set; }

		public byte[] PasswordSalt { get; set; }

	}
}
