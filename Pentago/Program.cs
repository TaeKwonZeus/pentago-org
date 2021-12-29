using Pentago.Services.Authentication;
using Pentago.Services.Engine;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>(_ => new AuthenticationService(builder.Configuration.GetConnectionString("App")));
builder.Services.AddScoped<IEngine, Engine>(_ => new Engine(builder.Configuration.GetConnectionString("Engine")));

var app = builder.Build();

if (!app.Environment.IsDevelopment()) app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();