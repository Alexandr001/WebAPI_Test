using AdminPanelApi.DataAccessLayer.Dapper;
using AdminPanelApi.DataAccessLayer.Interfaces;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddSingleton<StoreContext>();
builder.Services.AddSingleton<IProductDb, ProductDb>();
builder.Services.AddSingleton<ICategoryDb, CategoryDb>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();