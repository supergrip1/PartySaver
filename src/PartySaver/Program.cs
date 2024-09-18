using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using PartySaver.Components;
using PartySaver.Data;
using PartySaver.Data.Models;
using PartySaver.Services;

var builder = WebApplication.CreateBuilder(args);

DirectoryHelper.Initialize();

builder.Services.AddDbContext<DatabaseContext>(x => x.UseSqlite($"Data Source={DirectoryHelper.GetDatabaseFile()}"));

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<FileService>();
builder.Services.AddTransient<PhotoService>();


var app = builder.Build();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>().Database.Migrate();
}

app.Run();