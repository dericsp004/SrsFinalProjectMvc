using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{

    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name cannot be longer than 50 characters.")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [StringLength(15, ErrorMessage = "Phone Number cannot be longer than 15 characters.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(30, ErrorMessage = "Street cannot be longer than 30 characters.")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [StringLength(30, ErrorMessage = "City cannot be longer than 30 characters.")]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(30, ErrorMessage = "State cannot be longer than 30 characters.")]
        [Display(Name = "State")]
        public string State { get; set; }

        [StringLength(5, ErrorMessage = "Zip code cannot be longer than 5 characters.")]
        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }
    }
}
