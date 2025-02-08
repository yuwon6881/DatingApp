using DatingApp.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace DatingApp.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
