using VABL.Api.Repositories;
using VABL.Api.Routes;
using VABL.Api.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MongoDbSettings>();
builder.Services.AddSingleton<ILockerRepository,LockerRepository>();
builder.Services.AddCors();
var app = builder.Build();

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.MapGet("/", () => "Hello World!");
app.MapLockerListRoutes();
app.Run();
