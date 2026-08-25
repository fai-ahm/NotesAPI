using Microsoft.EntityFrameworkCore;
using Learning1.Models;

namespace Learning1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}