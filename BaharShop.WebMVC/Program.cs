using BaharShop.Application;
using BaharShop.Common.Enums;
using BaharShop.InfraStructure;
using BaharShop.InfraStructure.DBContext;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BaharShopDBContext>(options =>
                        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();
builder.Services.InfraStructureServiceCollections();
builder.Services.ApplicationServiceCollections();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
    options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
    options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
});

#region Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Authentication/SignIn";
        option.LogoutPath = "/Authentication/SignOut";
        option.ExpireTimeSpan = TimeSpan.FromDays(10);
        option.AccessDeniedPath = "/Authentication/SignIn";
    });
#endregion

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

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
