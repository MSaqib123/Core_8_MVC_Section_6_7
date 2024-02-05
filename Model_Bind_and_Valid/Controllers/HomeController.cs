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

        

    }
}
