using System.ComponentModel.DataAnnotations;
using MediaCatalog.Domain;

namespace MediaCatalog.Models
{
    public class StaffMemberViewModel
    {
        [Required]
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        [Required]
        public byte RoleId { get; set; }
        [Required]
        public int MediaId { get; set; }

        public Role Role { get; set; }
        public Media Media { get; set; }
    }
}