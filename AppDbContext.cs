using System;
using Microsoft.EntityFrameworkCore;

namespace EfCoreIssue
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
