using System;

namespace MediaCatalog.Domain
{
    public class CompanyAddress
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AddressId { get; set; }
        public byte AddressTypeId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
    }

}