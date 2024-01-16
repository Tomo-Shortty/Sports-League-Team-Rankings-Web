using MySqlConnector;
using SportsLeagueTeamRankings.Client.Pages;
using SportsLeagueTeamRankings.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportsLeagueTeamRankings.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SportsLeagueTeamRankingsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SportsLeagueTeamRankingsContext") ?? throw new InvalidOperationException("Connection string 'SportsLeagueTeamRankingsContext' not found.")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(SportsLeagueTeamRankings.Client._Imports).Assembly);

app.Run();
