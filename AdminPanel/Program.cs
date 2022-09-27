using AdminPanel.DataAccessLayer;
using AdminPanel.DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddSingleton(new StoreContext());
builder.Services.AddSingleton<IProductDb, ProductDb>();
builder.Services.AddSingleton<ICategoryDb, CategoryDb>();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
                       "default",
                       "{controller=Home}/{action=Index}/{id?}");

app.Run();