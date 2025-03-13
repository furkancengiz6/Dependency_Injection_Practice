using Dependency_Injection_Practice.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITeacher, Teacher>();
// Biri ITeacher isterse, ona Teacher'dan bir nesne olu�tur. Ama bu nesneyi sadece o istek i�in bir kere olu�tur, istek s�resince her yerde ayn� nesneyi kullan.
//Ama bu nesne nas�l, ne zaman, ne s�kl�kla olu�turulacak? ��te burada Scoped devreye giriyor:
//Her gelen HTTP iste�i (API �a�r�s�) i�in bir tane Teacher nesnesi olu�tur ve bu istek boyunca hep ayn� nesneyi kullan.
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
