using Microsoft.EntityFrameworkCore;

namespace NetCoreMVC.Entities
{
	public class TestDbContext : DbContext
	{
		//构造方法, 注入options
		public TestDbContext(DbContextOptions<TestDbContext> options)
			: base(options)
		{
		}
		//Users实体上下文
		public DbSet<User> Users { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//映射到数据库中的表
			modelBuilder.Entity<User>().ToTable("t_user");
			base.OnModelCreating(modelBuilder);
		}
	}
}
