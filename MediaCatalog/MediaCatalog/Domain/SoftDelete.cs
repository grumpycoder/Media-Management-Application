using System;

namespace MediaCatalog.Domain
{
    public class SoftDelete
    {
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedUser { get; set; }
    }
}
