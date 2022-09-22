using CodeFirst;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnetion"))
);

var app = builder.Build();

using (var scope = app.Services.CreateScope()) { 

    var context = scope.ServiceProvider.GetRequiredService<MVCContext>();
    context.Database.Migrate();
}

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

app.Run();
