using Microsoft.EntityFrameworkCore;
using TesteConfitec.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//conex�o com o banco de dados
builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer
    ("Data Source=DESKTOP-STM8CJR\\SQLEXPRESS; Initial Catalog=Crud_Confitec;Integrated Security=True;Timeout=15;Encrypt=False;"));

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
