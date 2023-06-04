using HomeTaskReletion.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ReletionDbContext>(opt =>
  opt.UseSqlServer("Server=DESKTOP-AF9EOHB\\SQLEXPRESS; Database=Yummi; Integrated Security = true")
);
var app = builder.Build();

app.MapControllerRoute(
    
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.UseStaticFiles();

app.Run();
