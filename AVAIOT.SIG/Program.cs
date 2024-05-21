using AVAIOT.SIG.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIG.Data.SigDbContext;
using Microsoft.Extensions.DependencyInjection;
using Radzen.Blazor;
using AVAIOT.SIG.Servicios.Interfaces;
using AVAIOT.SIG.Servicios;
using SIG.Data.Repositorio.Interfaz;
using SIG.Data.Repositorio;
using Radzen;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRadzenComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar servicios y repositorios
builder.Services.AddScoped<IRepositorioSIG, RepositorioSIG>();
builder.Services.AddScoped<IServicioSIG, ServicioSIG>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
