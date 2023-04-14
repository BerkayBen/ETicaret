using ETicaret.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration
    .GetConnectionString("DefaultConnectionString");

builder.Services.AddDbContext<AppDbContext>(opt => 
opt.UseSqlServer(connString));

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

AppDbInitiliazer.Seed(app);


app.Run();
