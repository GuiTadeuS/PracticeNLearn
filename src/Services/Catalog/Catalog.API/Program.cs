var builder = WebApplication.CreateBuilder(args);

// Add services

var app = builder.Build();

// Configure the HTTP request pipeline (HTTP request lifecycle)
app.MapGet("/", () => "Hello World!");

app.Run();
