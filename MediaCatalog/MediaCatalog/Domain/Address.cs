using System;

namespace MediaCatalog.Domain
{
    public class Address : SoftDelete
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public Int16? StateId { get; set; }
        public string PostalCode { get; set; }

        public virtual State State { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }

    }
}