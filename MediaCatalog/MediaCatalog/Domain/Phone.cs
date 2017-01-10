using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Domain
{
    public class Phone
    {
        public int Id { get; set; }

        public string Number { get; set; }
        public string Extension { get; set; }
    }
}