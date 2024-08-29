using Employe.Business.Interfaces;
using Employe.Business.Services;
using Employe.Data.Interfaces;
using Employe.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

//Services
builder.Services.AddTransient<IRepositoryEmploye, RepositoryEmploye>();
builder.Services.AddTransient<IEmployeService, EmployeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>{
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
