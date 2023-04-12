using IMDB.Services.EF_Services;
using IMDB.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using RazorPages_IMDB.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TitleDBContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("TitleDB")));
builder.Services.AddTransient<ITitleService, EFTitleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();