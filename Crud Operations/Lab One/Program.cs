using Lab_One.Services;
using Lab_One.Hubs;
using Microsoft.EntityFrameworkCore;

using Lab_One.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddSignalR();
// Add Custome Services to the Container
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddDbContext<DataBaseContext>(optionBuilder =>
{
    optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("Cs"));
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapHub<ChatHub>("OnlineChat"));

app.UseAuthorization();

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
