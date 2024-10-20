using Microsoft.EntityFrameworkCore;
using MemberManagementAPI.Domain.Entites; 
var builder = WebApplication.CreateBuilder(args);

// Get the connection string from configuration
var connections = builder.Configuration.GetConnectionString("Db");

// Register DbContext with MySQL
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseMySql(connections, ServerVersion.AutoDetect(connections)));


builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization(); 

app.MapControllers(); 

app.Run();
