using BandDB.Data;
using BandDB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=banddb.db"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/newband", async (Band band, AppDbContext db) => {
    db.Bands.Add(band);
    await db.SaveChangesAsync();
    return Results.Created("$/bands/{band.id}", band);
});

app.Run();
