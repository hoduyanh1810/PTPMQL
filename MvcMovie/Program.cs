using Microsoft.EntilyFrameWorkCore;
using MvcMovie.Models;

var builder = WebApplications.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") 
?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();
