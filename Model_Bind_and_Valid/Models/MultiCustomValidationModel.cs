using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Model_Bind_and_Valid.CustomValidators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.Models
{
    public class MultiCustomValidationModel
    {
        //________________ CustomValidation _____________
        //[MinimumYearValidator(2000, ErrorMessage = "Minimum year allowed is 2000")]
        //[MinimumYearValidator(2010, ErrorMessage = "Minimum year allowed is {0}")]
        [MinimumYearValidator(2016)]
        public DateTime? DOB { get; set; }

        //________________ MultiCustomValidation _____________
        public DateTime? FromDate { get; set; }
        [DateRangeValidator("FromDate",ErrorMessage="'FromDate' olderthen or equal to 'ToDate'")]
        public DateTime? ToDate { get; set; }
    }
}
