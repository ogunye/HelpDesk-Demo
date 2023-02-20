using HelpDesk.Api.Data;
using HelpDesk.Api.Repository;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//var configuration = new ConfigurationManager();


builder.Services.AddScoped<IProblemsRepository, ProblemRepository>();
builder.Services.AddDbContext<RepositoryContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
