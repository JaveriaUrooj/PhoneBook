using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook1.Models
{
    public class Contacts
    {
        [Required]
        [Display(Name ="Contact ID")]
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Person ID")]
        public int PersonId { get; set; }
    }
}