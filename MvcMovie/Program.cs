using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình Database Context với SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Thêm dịch vụ MVC (nếu bạn đang dùng Razor Pages hoặc Controllers)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Cấu hình endpoint
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Quan trọng: Chạy ứng dụng
app.Run();

