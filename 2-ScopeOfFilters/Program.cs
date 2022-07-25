using _2_ScopeOfFilters.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options =>
{
    options.Filters.Add<GlobalResourceFilter>();
});
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
