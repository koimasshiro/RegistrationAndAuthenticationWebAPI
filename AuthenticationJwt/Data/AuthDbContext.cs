using AuthenticationJwt.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationJwt.Data
{
	public class AuthDbContext : DbContext
	{
		public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
		{

		}

		public DbSet<User> Users => Set<User>();
	}
}
