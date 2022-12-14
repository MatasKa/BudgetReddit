using Microsoft.EntityFrameworkCore;
using SharedDomain;

namespace EfcDataAccess;

public class RedditContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = C:/Users/Matas K/Desktop/DNP/BudgetReddit/EfcDataAccess/Reddit.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasKey(post => post.Id);
        modelBuilder.Entity<User>().HasKey(user => user.Id);
    }
}