using Day6_efcore1.Context;
using Day6_efcore1.Repositories.Abstract;
using Day6_efcore1.Repositories.Concrete;
using Day6_efcore1.Services.Concrete;
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
// Dependency Injection LifeCycle
// AddSingleton -> Uygulama boyunca bellekte tek 1 tane instance tutar
// AddScopped -> Request response aras�nda ya�am s�resinde olan bir nesnenin instance 'sini tutar.
// AddTransiesnt -> Nesne ne zaman injection ile �a��r�l�yorsa her �a�r�ld��� yer i�i�n bir nesne bellekte tutar.
builder.Services.AddScoped<IPlayerRepository,PlayerRepository>();
builder.Services.AddScoped<PlayerService>();




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
