using Microsoft.EntityFrameworkCore;
using NotesAPI.Models;

namespace NotesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Note> Notes { get; set; }


    }
}