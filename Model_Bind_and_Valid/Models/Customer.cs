using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        [DisplayName("Person Name")]
        [StringLength(40,MinimumLength =3,ErrorMessage ="{0} should b/w {2} and {1}")]
        //{0} name ,  {1} maxLenght , {2} minLength  
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        [DisplayName("Product Price")]
        [Range(0, 999.99 , ErrorMessage = "{0} should b/w ${1} and ${2}")]
        //{0} name ,  {1} Max , {2} min
        public string? Price { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        [EmailAddress(ErrorMessage = "Please give Email address")]
        public string? Email { get; set; }

        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic characters and spaces are allowed.")]
        public string? SirName { get; set; }

        //[Phone(ErrorMessage = "Phone Number requird")]
        [RegularExpression(@"^\+\d{4,5}-\d{7,10}$", ErrorMessage = "Invalid phone number format. Example: +92312-1234567")]
        [ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Password { get; set; }

        [Compare("Password",ErrorMessage ="{0} Not match with {0}")]
        [DisplayName("Re-enter Password")]
        public string? ConfirmPassword { get; set; }
    }
}
