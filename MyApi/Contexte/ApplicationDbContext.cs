using Microsoft.EntityFrameworkCore;


namespace MyApi.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
        
        public DbSet<Entity> Entitys { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        // nom de la table en BDD 
    }
}