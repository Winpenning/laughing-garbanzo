using CDJ_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureDatabase(builder);
ConfigureEndpoints(builder);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    DocumentAppEndpoints(app);
    
app.MapControllers();

app.Run();

static void ConfigureDatabase(WebApplicationBuilder builder){
    var connectionString = builder.Configuration.GetConnectionString("Default");
    builder.Services.AddDbContext<AppDataContext>(options =>
    {
    options.UseSqlServer(connectionString);
    });
}
static void ConfigureEndpoints(WebApplicationBuilder builder){
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
static void DocumentAppEndpoints(WebApplication app){
    app.MapSwagger();
    app.UseSwagger();
    app.UseSwaggerUI();
}