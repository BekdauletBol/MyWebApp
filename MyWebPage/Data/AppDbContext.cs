using Microsoft.EntityFrameworkCore;
using MyWebPage.Models;

namespace MyWebPage.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Feedback> Feedbacks { get; set; }
}
