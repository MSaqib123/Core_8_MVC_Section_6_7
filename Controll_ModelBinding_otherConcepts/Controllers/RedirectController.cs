using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    public class RedirectController : Controller
    {
        //========================================
        //--------- RedirectToAction -------------
        //========================================
        public IActionResult Index()
        {
            //return new RedirectToActionResult("Index", "StatusCode", new { bookId = 14, isLoggedIn = true });
            return RedirectToAction("Index", "StatusCode",new { bookId = 14 , isLoggedIn =true});
        }

        //========================================
        //--------- LocalRedirect -------------
        //========================================
        public IActionResult Index2()
        {
            return LocalRedirect("~/StatusCode/Index?bookId=14&isLoggedIn=true");
        }

        //========================================
        //--------- RedirectToActionPermanent -------------
        //========================================
        public IActionResult Index1()
        {
            return RedirectToActionPermanent("Index", "StatusCode", new { bookId = 14, isLoggedIn = true });
        }

        

    }
}
