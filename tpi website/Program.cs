using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using tpi_website.Areas.Identity.Data;
using tpi_website.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("tpi_websiteContextConnection") ?? throw new InvalidOperationException("Connection string 'tpi_websiteContextConnection' not found.");

builder.Services.AddDbContext<tpi_websiteContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<tpi_websiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<tpi_websiteContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();

