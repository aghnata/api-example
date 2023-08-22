using Databases.Entities;
using Microsoft.EntityFrameworkCore;

namespace Databases.EntityFramework
{
    public class ApplicationSqlServerContext : DbContext
    {
        public ApplicationSqlServerContext(DbContextOptions<ApplicationSqlServerContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItemEntity> TodoItems { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
    }
}
