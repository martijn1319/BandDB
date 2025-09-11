using System;

namespace BandDB.Models;

public class Musician {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Instrument { get; set; }
}