using Microsoft.EntityFrameworkCore;

namespace NetCoreMVC.Entities
{
	public class TestDbContext : DbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> options)
			: base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("t_user");
			base.OnModelCreating(modelBuilder);
		}
	}
}
