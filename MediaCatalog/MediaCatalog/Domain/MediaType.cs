using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Domain
{
    public class MediaType
    {
        public byte Id { get; set; }
        [Display(Name = "Type")]
        public string Name { get; set; }
    }
}