using Microsoft.AspNetCore.Mvc;
using Model_Bind_and_Valid.Models;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class HomeController:Controller
    {
        //=============================================
        //--------- 1. Adding Default Aciton ---------
        //=============================================
        #region default

        [Route("/")]
        public string Index()
        {
            return "This is HomePage";
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

        public IActionResult RoutingDrd([FromRoute]int? bookid, [FromQuery] string islogedIn)
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

    }
}
