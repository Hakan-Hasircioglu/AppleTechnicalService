using TechServe.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechServe.Data;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Blazored.LocalStorage;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<TechServeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TechServeContext") ?? throw new InvalidOperationException("Connection string 'TechServeContext' not found.")));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddScoped<ProtectedSessionStorage>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
