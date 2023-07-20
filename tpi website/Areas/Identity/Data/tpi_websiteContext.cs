using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tpi_website.Areas.Identity.Data;
using tpi_website.Models;

namespace tpi_website.Data;

public class tpi_websiteContext : IdentityDbContext<tpi_websiteUser>
{
    public tpi_websiteContext(DbContextOptions<tpi_websiteContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<tpi_website.Models.Thrifty>? Thrifty { get; set; }
}
