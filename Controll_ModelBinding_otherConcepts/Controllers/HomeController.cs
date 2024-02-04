using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Controll_ModelBinding_otherConcepts.Controllers
{
    [Controller]
    public class HomeController
    {
        //=============================================
        //_______ 1. Adding Controller Action __________
        //=============================================
        #region Controller
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
        #endregion

        //=============================================
        //--------- 2. Adding Default Aciton ---------
        //=============================================
        #region default

        [Route("/")]
        public string Index()
        {
            return "This is HomePage";
        }
        #endregion


        //=============================================
        //------------ 3. FileResult --------------
        //=============================================
        #region FileResult
        //___ VertualFile __
        [Route("download1")]
        public VirtualFileResult download1()
        {
            return new VirtualFileResult("/excelSheet.xlsx","application/pdf");
        }
        //___ physicalFile __
        [Route("download2")]
        public PhysicalFileResult download2()
        {
            return new PhysicalFileResult(@"C:\AspnetCore\excelSheet.xlsx", "application/pdf");
        }
        //___ FileContentResult __
        [Route("download3")]
        public FileContentResult download3()
        {
            var bytes = System.IO.File.ReadAllBytes(@"C:\AspnetCore\excelSheet.xlsx");
            return new FileContentResult(bytes, "application/pdf");
        }
        //___ Common File  __
        #endregion
    }
}
