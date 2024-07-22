using BlazorCrudDotNet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Game> Games { get; set; }
}