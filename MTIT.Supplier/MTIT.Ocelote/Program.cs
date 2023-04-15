using Ocelot.Middleware;
using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();
var app = builder.Build();

app.MapGet("/", () => "Successfuly Launched Dialog Company API");
app.UseOcelot();

app.Run();
