using Api.W.Movies.Backend.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.W.Movies.Backend.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Category>Categories { get; set; }
}