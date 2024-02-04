var builder = WebApplication.CreateBuilder(args);

//=====================================
//=========== Controllers ============
//=====================================
builder.Services.AddControllers();
var app = builder.Build();

//___ Adding Controller Middleware ___
app.UseRouting();
app.MapControllers();
//app.MapGet("/", () => "Hello World!");

app.Run();
