using Day6_efcore1.Context;
using Day6_efcore1.Repositories.Abstract;
using Day6_efcore1.Repositories.Concrete;
using Day6_efcore1.Services.Concrete;
using Microsoft.EntityFrameworkCore;
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
builder.Services.AddDbContext<BaseDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});
// Dependency Injection LifeCycle
// AddSingleton -> Uygulama boyunca bellekte tek 1 tane instance tutar
// AddScopped -> Request response arasýnda yaþam süresinde olan bir nesnenin instance 'sini tutar.
// AddTransiesnt -> Nesne ne zaman injection ile çaðýrýlýyorsa her çaðrýldýðý yer içiçn bir nesne bellekte tutar.
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
