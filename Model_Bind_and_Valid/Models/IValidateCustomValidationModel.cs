using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Model_Bind_and_Valid.CustomValidators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.Models
{
    public class IValidateCustomValidationModel : IValidatableObject
    {
        public string PersonName { get; set; }

        public DateTime? FromDate { get; set; }

        [DateRangeValidator("FromDate",ErrorMessage="'FromDate' olderthen or equal to 'ToDate'")]
        public DateTime? ToDate { get; set; }

        public DateTime? DOB { get; set; }
        public DateTime? Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //yield ---> is used to convert multiple values
            if (DOB.HasValue == false && Age.HasValue == false)
            {
                yield return new ValidationResult("Either of DOB or age should be need");
            }
        }
    }
}
