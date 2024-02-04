using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class ModelBindingProccessController:Controller
    {
        //=============================================
        //_______ ModelBindingProccess __________
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


    }
}
