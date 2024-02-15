using DateMe.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//this is how you set up the web app to use the data base. this one is using sqlite
// this will go to your appsettings.json and look for the connections strings and include the DatingConnection that you have created. now if you ever need to change anyting about Datingconneciton you only need to do it once
builder.Services.AddDbContext<DatingApplicationContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:DatingConnection"]);
});

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
