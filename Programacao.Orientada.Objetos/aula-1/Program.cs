using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços necessários.
builder.Services.AddControllers();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure a aplicação.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Adicione os endpoints.
app.MapGet("/fibonacci", (int valorSequencia) =>
{

});

app.MapGet("/conversor", (int celsius) =>
{

});

app.Run();