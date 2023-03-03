using Microsoft.EntityFrameworkCore;
using Bustamante_SportsStore.Models;
var builder = WebApplication.CreateBuilder(args);
//
builder.Services.AddControllersWithViews();
// Add services to the container.

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});
//
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
//
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// 
app.MapDefaultControllerRoute();

app.Run();
