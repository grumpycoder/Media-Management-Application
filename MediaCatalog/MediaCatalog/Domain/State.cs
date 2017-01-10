using System;

namespace MediaCatalog.Domain
{
    public class State
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}