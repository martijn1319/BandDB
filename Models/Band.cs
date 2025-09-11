using System;

namespace BandDB.Models;

public class Band 
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public string Genre { get; set; } = "";
    public int YearFormed { get; set; }
    public bool IsActive { get; set; }

    public Band(string name, string genre, int yearFormed, bool isActive) 
    {
        Id = Guid.NewGuid();
        Name = name;
        Genre = genre;
        YearFormed = yearFormed;
        IsActive = isActive;
    }

    public Band() { }
}