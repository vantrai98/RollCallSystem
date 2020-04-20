using RCS.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCS.Web.Controllers.api
{
    public class HomeController : BaseApiController
    {
        public HomeController()
        {
            RSCServiceClient = new RCSService.RCSServiceClient();
        }
        [HttpGet]
        public Test Test()
        {
            Test a = RSCServiceClient.Test();
            return a;
        } 
    }
}
