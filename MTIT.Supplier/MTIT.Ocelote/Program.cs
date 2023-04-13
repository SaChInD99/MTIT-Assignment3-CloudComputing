var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Successfuly Launched Dialog Company API");

app.Run();
