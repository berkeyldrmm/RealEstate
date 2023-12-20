using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using RealEstate.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.DependenciesContainer();
builder.Services.AddDbContext<RealEstateDBContext>();

builder.Services.AddAuthentication(
               CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(x =>
               {
                   x.Cookie.Name = "Auth";
                   x.LoginPath = "/login";
                   x.AccessDeniedPath = "/login";
               });

//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();

//    config.Filters.Add(new AuthorizeFilter(policy));
//});

builder.Services.AddIdentity<User, Role>(x =>
{
    x.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<RealEstateDBContext>()
    .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider)
    .AddEntityFrameworkStores<RealEstateDBContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
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
    name: "login",
    pattern: "Account/{controller=Login}/{action=Index}/{id?}"
);

app.Run();
