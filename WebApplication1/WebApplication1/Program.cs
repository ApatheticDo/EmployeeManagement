//using Microsoft.AspNetCore.Routing.Constraints;
//using Microsoft.EntityFrameworkCore;
//using System;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using WebApplication1.Models;
//using Microsoft.AspNetCore.Identity;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();



//// Configure Entity Framework Core to use SQL Server

//builder.Services.AddDbContext<EmployeeMngDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
////builder.Services.AddDbContext<EmployeeMngDbContext>(option => option.UseSqlServer("Server==VNS00005\\SQLEXPRESS;Database=DataTest1;Trusted_Connection=True;"));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

////Configuring Sesssion Service
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(10);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;

//}); 

//builder.Services.AddRazorPages();

//var app = builder.Build();
//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    app.UseHsts();

//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//// Configuring Session Middeware
//app.UseSession();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Login}/{action=Login}/{id?}");

//app.Run();


using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ
builder.Services.AddControllersWithViews();

// Thêm đăng ký cho IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Cấu hình Entity Framework Core để sử dụng SQL Server
builder.Services.AddDbContext<EmployeeMngDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cấu hình Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(500);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});                                                                                                           

var app = builder.Build();

// Cấu hình HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();

