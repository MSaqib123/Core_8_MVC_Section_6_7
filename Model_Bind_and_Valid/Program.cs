using Model_Bind_and_Valid.CustomMModelBinder;

var builder = WebApplication.CreateBuilder(args);

//===============================================
//_______ Adding globalPersonModelBinder ______
//===============================================
builder.Services.AddControllers(opt =>
{
    opt.ModelBinderProviders.Insert(0, new globalPersonModelBinder());
});

var app = builder.Build();

//___ Adding Controller Middleware ___
app.UseRouting();
app.MapControllers();

app.Run();
