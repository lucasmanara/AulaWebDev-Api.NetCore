using AulaWebDev.Infra.Dependencias;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddLogging();

builder.Services.AddInfraestrutura(builder.Configuration);
builder.Services.AddServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
