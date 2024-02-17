using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentPortal_Core.Entities.UserEntities.Concrete;
using StudentPortal_DataAccess.Context;
using StudentPortal_DataAccess.Context.IdentityContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionString = builder.Configuration.GetConnectionString("PostgresSQLConnection");
var connectionStringIdentity = builder.Configuration.GetConnectionString("PostgresSQLIdentityConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});


builder.Services.AddDbContext<AppIdentityDbContext>(options =>
{
    options.UseNpgsql(connectionStringIdentity);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedPhoneNumber = false;
    x.SignIn.RequireConfirmedAccount = false;
    x.SignIn.RequireConfirmedEmail = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 1;
    x.Password.RequiredUniqueChars =  0;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireLowercase = false;

})

    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
