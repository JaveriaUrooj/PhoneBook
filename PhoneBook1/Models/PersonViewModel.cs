using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook1.Models
{
    public class PersonViewModel
    {
        [Display(Name = "Person ID")]
        [Required]
        public int personId { get; set; }
        
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [Required]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
       
        public DateTime? DteOfBirth { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Added ON")]
        [Required]
        public DateTime AddedOn { get; set; }

        [Display(Name = "Added By")]
        [Required]
        public string AdddedBy { get; set; }

        [Display(Name = "Home Address")]
        [Required]
        public string HomeAddress { get; set; }

        [Display(Name = "Home City")]
        [Required]
        public string HomeCity { get; set; }

        [Display(Name = "FaceBook Account ID")]
        [Required]
        public string FacBookAccountId { get; set; }

        [Display(Name = "Linked In ID")]
        [Required]
        public string LinkedInId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated ON")]
        [Required]
        public DateTime? UpdateOn { get; set; }

        [Display(Name = "Image Path")]
        [Required]
        public string ImagePath { get; set; }

        [Display(Name = "Twitter ID")]
        [Required]
        public string TwitterId { get; set; }

        [EmailAddress]
        [Display(Name = "Email ID")]
        [Required]
        public string EmailId { get; set; }
        
    }
}