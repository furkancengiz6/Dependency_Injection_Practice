using Dependency_Injection_Practice.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITeacher, Teacher>();
// Biri ITeacher isterse, ona Teacher'dan bir nesne oluþtur. Ama bu nesneyi sadece o istek için bir kere oluþtur, istek süresince her yerde ayný nesneyi kullan.
//Ama bu nesne nasýl, ne zaman, ne sýklýkla oluþturulacak? Ýþte burada Scoped devreye giriyor:
//Her gelen HTTP isteði (API çaðrýsý) için bir tane Teacher nesnesi oluþtur ve bu istek boyunca hep ayný nesneyi kullan.
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
