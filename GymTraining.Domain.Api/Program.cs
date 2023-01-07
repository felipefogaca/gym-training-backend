using GymTraining.Domain.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddAppConnections(builder.Configuration)
    .AddDomainServices()
    .AddAndConfigureControllers();
    

var app = builder.Build();


app.UseDocumentation();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();
