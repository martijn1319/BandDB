using System;

namespace BandDB.Models;

public class Musician {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Instrument { get; set; }
    public bool IsCurrentMember { get; set; }
    public int YearJoined { get; set; }
    public int? YearLeft { get; set; }

    public Musician(string name, string instrument, bool isCurrentMember, int yearJoined, int? yearLeft)
    {
        Id = Guid.NewGuid();
        Name = name;
        Instrument = instrument;
        IsCurrentMember = isCurrentMember;
        YearJoined = yearJoined;
        YearLeft = yearLeft;
    }

    public Musician() { }
}