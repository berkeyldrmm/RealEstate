using BusinessLayer.Validation;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using RealEstate.Extensions;
using RealEstate.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.DependenciesContainer();
builder.Services.AddDbContext<RealEstateDBContext>();
//builder.Services.AddDbContext<RealEstateDBContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:SqlServer"]));
builder.Services.AddMvc();
builder.Services.AddFluentValidation().AddValidatorsFromAssemblyContaining<LoginValidation>();

builder.Services.AddAuthentication(
               CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(x =>
               {
                   x.Cookie.Name = "Auth";
                   x.LoginPath = "/login";
                   x.AccessDeniedPath = "/login";
               });

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();

    config.Filters.Add(new AuthorizeFilter(policy));
});

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

app.UseStatusCodePagesWithReExecute("/Error/ErrorPage", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "login",
    pattern: "Account/{controller=Login}/{action=Index}/{id?}"
);

app.Run();
