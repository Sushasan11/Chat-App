using Microsoft.EntityFrameworkCore;
using ChatApp.Server.Models;

namespace ChatApp.Server.Data;
public class AppDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
