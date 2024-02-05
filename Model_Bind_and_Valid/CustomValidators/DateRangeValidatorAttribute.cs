using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Model_Bind_and_Valid.CustomValidators
{
    public class DateRangeValidatorAttribute : ValidationAttribute
    {
        public string OtherPropertyName { get; set; }

        #region Constructor
        //public DateRangeValidatorAttribute() { }    in this paremter is requed
        public DateRangeValidatorAttribute(string otherPropertyName)
        {
            OtherPropertyName = otherPropertyName;
        }
        #endregion

        #region IsValid
        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //_____ currentProperty from_date ____
                DateTime to_date = (DateTime)value;

                //_____ otherProperty to_date ____
                //we have name of otherProperty
                //but  value will come from DataBinding(Context) by (Reflection) concept
                //Reflection is used Read MataData from object dynamicaly
                PropertyInfo? otherProperty = validationContext.ObjectType.GetProperty(OtherPropertyName);
                //DateTime from_date = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));

                if (otherProperty != null)
                {
                    DateTime from_date = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));
                    if (from_date > to_date)
                    {
                        return new ValidationResult(
                            ErrorMessage,
                            new string[] {
                            OtherPropertyName,//"FromDate",
                            validationContext.MemberName//"ToDate"
                            }
                          );
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                return null;
            }
            return null;
        }
        #endregion
    }
}
