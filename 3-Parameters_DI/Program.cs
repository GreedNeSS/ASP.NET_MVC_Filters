using _3_Parameters_DI.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddScoped<LogResourceFilter>();
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
