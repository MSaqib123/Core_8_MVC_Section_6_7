var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

//___ Adding Controller Middleware ___
app.UseRouting();
app.MapControllers();

app.Run();
