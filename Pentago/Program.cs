using Pentago.Services.Authentication;
using Pentago.Services.Engine;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddScoped<ILoginService, LoginService>(_ => new LoginService(builder.Configuration.GetConnectionString("App")));
builder.Services.AddScoped<IRegisterService, RegisterService>(_ => new RegisterService(builder.Configuration.GetConnectionString("App")));
builder.Services.AddScoped<IEngineService, EngineService>(_ => new EngineService(builder.Configuration.GetConnectionString("Engine")));

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