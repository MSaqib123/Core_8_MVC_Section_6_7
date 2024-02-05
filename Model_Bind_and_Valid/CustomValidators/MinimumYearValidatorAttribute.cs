using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.CustomValidators
{
    public class MinimumYearValidatorAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value != null)
            {
                DateTime date = (DateTime)value;
                if (date.Year >= 2000)
                {
                    return new ValidationResult("Minimum year allowed is 2000");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
    }
}
