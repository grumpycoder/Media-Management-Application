using System;
using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Models
{
    public class PersonPhoneViewModel
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public byte PhoneTypeId { get; set; }
        [Required]
        [UIHint("Phone")]
        [StringLength(10, ErrorMessage = "Phone number can be no longer than 10 digits.")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "Phone number can be digits 0-9 only.")]
        public string Number { get; set; }

    }
}