using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Model_Bind_and_Valid.Models
{
    public class Bind_BindNever
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Price { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Email { get; set; }

        //__________ BindNever _________
        [BindNever]
        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? SirName { get; set; }

        //__________ BindNever _________
        [BindNever]
        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? ConfirmPassword { get; set; }
    }
}
