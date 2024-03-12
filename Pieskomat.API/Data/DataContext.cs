using Microsoft.EntityFrameworkCore;
using Pieskomat.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pieskomat.API;

public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Post> Posts => Set<Post>();


}
