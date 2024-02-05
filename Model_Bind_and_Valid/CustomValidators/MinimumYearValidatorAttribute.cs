using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.CustomValidators
{
    public class MinimumYearValidatorAttribute:ValidationAttribute
    {
        public int MinimumYear { get; set; }
        public MinimumYearValidatorAttribute(){}
        public MinimumYearValidatorAttribute(int minimuYear)
        {
            MinimumYear = minimuYear;
        }

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value != null)
            {
                DateTime date = (DateTime)value;
                //if (date.Year >= 2000)
                if (date.Year >= MinimumYear)
                {
                    //return new ValidationResult("Minimum year allowed is 2000");
                    //____ PreDefined ErrorMessage ___
                    return new ValidationResult(ErrorMessage);
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
