using WebAPI_Test.BusinessLayer.Implementations;
using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.DataAccessLayer.Implementations;
using WebAPI_Test.DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<IProductDb, ProductDb>();
builder.Services.AddSingleton<IProductBl, ProductBl>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();