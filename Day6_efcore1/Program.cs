using Day6_efcore1.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Bir veri tabaný olsun ve bu veri tabaný sporcularýn ve  branþýnýn tutylduðu bir sistem.
// Sporcu -> Id, Adý, Yaþý , Branþý, Takýmý , Piyasa Deðeri.
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<BaseDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
