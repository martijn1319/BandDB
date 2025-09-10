using BandDB.Data;
using BandDB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=banddb.db"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
