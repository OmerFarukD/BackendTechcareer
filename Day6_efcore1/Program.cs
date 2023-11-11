using Day6_efcore1.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Bir veri taban� olsun ve bu veri taban� sporcular�n ve  bran��n�n tutyldu�u bir sistem.
// Sporcu -> Id, Ad�, Ya�� , Bran��, Tak�m� , Piyasa De�eri.
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
