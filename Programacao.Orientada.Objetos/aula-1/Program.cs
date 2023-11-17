using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços necessários.
builder.Services.AddControllers();


builder.Services.AddSwaggerGen();

var app = builder.Build();



// Adicione os endpoints.
app.MapGet("/corrida-cachorro", () =>
{
    //TODO    

})
    .WithName("corrida-cachorro")
    .WithOpenApi();


// Adicione os endpoints.
app.MapGet("/fibonacci", (int valorSequencia) =>
{

}).WithName("fibonacci").WithOpenApi();
app.MapGet("/conversor", (int celsius) =>
{

}).WithName("conversor").WithOpenApi();


app.UseSwagger();
app.UseSwaggerUI();

app.Run();