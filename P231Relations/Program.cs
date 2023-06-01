using Microsoft.EntityFrameworkCore;
using P231Relations.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RelationsDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-NH7SON4\\SQLEXPRESS;Database=P231EFRelations;Integrated Security=true");
});

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
