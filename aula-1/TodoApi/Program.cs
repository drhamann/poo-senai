using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

 
app.MapGet("/fibonnaci", (int sequenceNumber) =>
{ 
    List<int> fibonacciList = new List<int>();

    for (int i = 1; i <= sequenceNumber; i++)
    {
        if(i == 1 || i == 2){
            fibonacciList.Add(1);
        }
        else{
            var lastvalue = fibonacciList[i-2];
            var lastlastvalue = fibonacciList[i-3];
            var newValue = lastlastvalue + lastvalue;
            fibonacciList.Add(newValue);
        }
    }
    return fibonacciList;

} );

app.Run();
