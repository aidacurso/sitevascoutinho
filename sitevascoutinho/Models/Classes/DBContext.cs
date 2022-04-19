using Microsoft.EntityFrameworkCore;

namespace sitevascoutinho.Models.Classes
{
	public class DBContext : DbContext
	{
		public DBContext(DbContextOptions<DBContext> options) : base(options)
		{

		}
		public DbSet<Noticia>? GuardarNoticia { get; set; }
	}
}
