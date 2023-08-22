using Databases.Entities;
using Microsoft.EntityFrameworkCore;

namespace Databases.EntityFramework
{
    public class ApplicationMySqlContext : DbContext
    {
        public ApplicationMySqlContext(DbContextOptions<ApplicationMySqlContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItemEntity> TodoItems { get; set; }
		public DbSet<UserEntity> Users { get; set; } = null!;

	}
}
