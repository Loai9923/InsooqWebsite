




using inSooqWebsite.Services.Configration;
using InsooqWebsite.Domains.Cores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace inSooqWebsite.Services;

public class InSooqDbContext : DbContext
{
    public InSooqDbContext(DbContextOptions<InSooqDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        UserConfig.UserConfigrations(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<User> Users{get; set;}

    public DbSet<Role> Roles {get; set;}

    public DbSet<Status> Statuss{get; set;} 



}
