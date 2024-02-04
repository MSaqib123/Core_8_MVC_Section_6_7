using Microsoft.AspNetCore.Mvc;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    public class HomeController
    {
        [Route("Pakistan")]
        public string ListRecords()
        {
            return "Pakistan";
        }
    }
}
