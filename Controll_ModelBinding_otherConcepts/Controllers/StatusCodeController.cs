using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class StatusCodeController:Controller
    {
        //=============================================
        //_______ StatusCode __________
        //=============================================
        //Ok  We have
        //----- StatusCodeResult -----------
        //return new StatusCodeResult()   or    return StatusCode();

        //----- UnauthorizedResult -----------
        //return new UnAtuhorizedResult()   or    return Unauthorized();

        //----- BadRequestResult -----------
        //return new BadRequestResult()   or   return BadRequest();

        //----- NotFoundResult -----------
        //return new NotFoundResult()   or   return NotFound();

        #region StatusCode
        [Route("Book")]
        public IActionResult Index()
        {
            if (!Request.Query.ContainsKey("bookId"))
            {
                //Response.StatusCode == 400;
                //return Content("Book Id is not defined");
                //return new BadRequestResult();
                return BadRequest("Book id is not supplied");
            }
            //book id Can't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                //Response.StatusCode = 400;
                //return Content("Book id cannot be empty");
                return BadRequest("Book id cannot be empty");
            }
            int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);
            if (bookId <= 0)
            {
                //Response.StatusCode = 400;
                //return Content("Book id cant't be less then or eques to 0");
                return BadRequest("Book id cant't be less then or eques to 0");
            }
            if (bookId >= 1000)
            {
                //Response.StatusCode = 400;
                //return Content("Book id cant't be greter then or eques to 1000");
                return BadRequest("Book id cant't be greter then or eques to 1000");
            }

            //check Login or not
            if (Convert.ToBoolean(Request.Query["isLoggedIn"])==false)
            {
                Response.StatusCode = 401;
                //return Content("User must be authentication");

                //return Unauthorized("User Must be authetication");
                return StatusCode(401);
            }

            return File("/sample.pdf","applicaton/pdf");
        }
        
        #endregion


    }
}
