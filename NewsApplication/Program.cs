using DataAccess.Contexts;
using DataAccess.Services;
using DataAccess.Services.Bases;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region IoC
var connectionString = builder.Configuration.GetConnectionString("NewsApplicationDb");
builder.Services.AddDbContext<Db>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<Db>(options => options.UseNpgsql(connectionString));
builder.Services.AddScoped<CategoryServiceBase, CategoryService>();
builder.Services.AddScoped<CornerPostServiceBase, CornerPostService>();
builder.Services.AddScoped<NewsServiceBase, NewsService>();
builder.Services.AddScoped<WriterServiceBase, WriterService>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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