using Microsoft.AspNetCore.Mvc;
using Model_Bind_and_Valid.Models;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class ModelBindingProccessController:Controller
    {
        //=============================================
        //_______ 1. ModelBindingProccess __________
        //=============================================
        #region ModelBindingProccess
        [Route("Book")]
        public IActionResult Index(int bookid,bool isLoggedIn)
        {
            if (bookid == null)
            {
                return BadRequest("Book id is not supplied");
            }
            //book id Can't be empty
            if (bookid == null)
            {
                return BadRequest("Book id cannot be empty");
            }
            //int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);
            int bookId = bookid;
            if (bookId <= 0)
            {
                return BadRequest("Book id cant't be less then or eques to 0");
            }
            if (bookId >= 1000)
            {
                return BadRequest("Book id cant't be greter then or eques to 1000");
            }

            //check Login or not
            //if (Convert.ToBoolean(Request.Query["isLoggedIn"])==false)
            if (isLoggedIn == false)
            {
                return StatusCode(401);
            }

            return File("/sample.pdf","applicaton/pdf");
        }

        #endregion


        //=============================================
        //--------- 2. FromRoute ,FromQuery ---------
        //=============================================
        #region FromRoute FromQuery
        //1. fromRoute
        //For example, if you have a URL like /books/123, where 123 is the book ID, [FromRoute]
        //2. fromQuery
        //For example, in the URL /search?query=ASP.NET, [FromQuery]

        public IActionResult RoutingDrd([FromRoute] int? bookid, [FromQuery] string islogedIn)
        {
            return View();
        }
        #endregion

        //=============================================
        //--------- 3. ModelClass ---------
        //=============================================
        #region ModelClass
        [Route("ModelClass")]
        public IActionResult ModelClass(Book books)
        {
            return View();
        }
        #endregion

        //=============================================
        //------ 4. form-urlencoded and form-data ------
        //=============================================
        #region form-urlencoded and form-data 
        //___ 1. form-urlencoded ___
        //for small formData 
        //file can not be add

        //___ 1. form-data ___
        //for larg data
        //file  allewed
        [Route("FormData_incodeFormData")]
        public IActionResult FormData_incodeFormData(int id, Book books)
        {
            return View();
        }
        #endregion

        //=============================================
        //------- 5. Model Validation + model_State ------
        //=============================================
        #region Model_Validation_modelState
        //1.create perons model with  Attributes
        [Route("ModelValdation")]
        public IActionResult ModelValdation(Person person)
        {
            if (ModelState.IsValid)
            {
                //jb sb ok ho to 
                return View("Good mera bchaa");
            }
            else
            {
                //_____________ long Code 1 ________
                //List<string> errorList = new List<string>();
                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                //_____________ short LamdaExpress Linque ________
                //List<string> errorList = new List<string>();
                //ModelState.Values
                //    .SelectMany(value => value.Errors) //outer loop
                //    .Select(err => err.ErrorMessage).ToList();  //inner loop
                //string errors = string.Join("\n",errorList);

                //_____________ short LamdaExpress Linque ________
                string error = string.Join("\n", ModelState.Values
                    .SelectMany(value => value.Errors) //outer loop
                    .Select(err => err.ErrorMessage));  //inner loop

                return NotFound(error);
            }
        }
        #endregion


        //=============================================
        //------- 6. All Validation Attributes --------
        //=============================================
        #region All_Validation_Attribute
        [Route("AllValidationAttri")]
        public IActionResult AllValidationAttri(Customer customer)
        {
            if (ModelState.IsValid)
            {
                //jb sb ok ho to 
                return View("Good mera bchaa");
            }
            else
            {
                //_____________ short LamdaExpress Linque ________
                string error = string.Join("\n", ModelState.Values
                    .SelectMany(value => value.Errors) //outer loop
                    .Select(err => err.ErrorMessage));  //inner loop

                return NotFound(error);
            }
        }
        #endregion


        //=============================================
        //------ 7. CustomValidation for SingleProp  ------
        //=============================================
        #region All_Validation_Attribute
        [Route("CustomerValdation")]
        public IActionResult CustomerValdation(CustomValidationModel val)
        {
            if (ModelState.IsValid)
            {
                //jb sb ok ho to 
                return View("Good mera bchaa");
            }
            else
            {
                //_____________ short LamdaExpress Linque ________
                string error = string.Join("\n", ModelState.Values
                    .SelectMany(value => value.Errors) //outer loop
                    .Select(err => err.ErrorMessage));  //inner loop

                return NotFound(error);
            }
        }
        #endregion

        //=============================================
        //---------- 8. IValidatableObject ------------
        //=============================================
        #region IValidatableObject
        //if u don't want to create reusalbe Validatin then use IValidationobject

        #endregion
    }
}
