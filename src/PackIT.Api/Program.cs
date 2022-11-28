using PackIT.Application;
using PackIT.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();