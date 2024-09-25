using Ecommerce.Application;
using Ecommerce.Infrastructure;
using Ecommerce.Web.Components;
using Ecommerce.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

// Inject service from Application
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddScoped<FetchDataService>();


builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMvc(x =>
{
    x.EnableEndpointRouting = false;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
   
    app.UseHsts();
}
// Add API 
app.UseMvcWithDefaultRoute();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
