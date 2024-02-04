using Microsoft.AspNetCore.Mvc;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class HomeController
    {
        //=============================================
        //_______ 1. Adding Controller Action __________
        //=============================================
        [Route("Pakistan1")]
        [Route("Pakistan2")]
        public string ListRecords()
        {
            return "Pakistan";
        }

        [Route("ContactUs/{id}")]
        public string ContactUs()
        {
            return "This is HomePage";
        }

        //=============================================
        //--------- 2. Adding Default Aciton ---------
        //=============================================
        [Route("/")]
        public string Index()
        {
            return "This is HomePage";
        }


    }
}
