using LogisticsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogisticsApi.Data;
public class LogisticsDbContext : DbContext
{
    public LogisticsDbContext(DbContextOptions<LogisticsDbContext> options): base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}