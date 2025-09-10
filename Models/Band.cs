using System;


namespace BandDB.Models 
{
    public class Band 
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Genre { get; set; } = "";
        public int YearFormed { get; set; }
        public bool IsActive { get; set; }
    }
}