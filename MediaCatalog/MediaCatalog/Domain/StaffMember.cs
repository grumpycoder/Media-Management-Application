using System;

namespace MediaCatalog.Domain
{
    public class StaffMember : SoftDelete
    {
        public Int16 Id { get; set; }

        public int PersonId { get; set; }
        public byte RoleId { get; set; }
        public int MediaId { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }

        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }
        public virtual Media Media { get; set; }

    }
}