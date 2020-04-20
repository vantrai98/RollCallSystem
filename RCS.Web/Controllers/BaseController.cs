using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace RCS.Web.Controllers
{
    public class BaseController : Controller
    {
        public static RCSService.RCSServiceClient RSCServiceClient;
    }
}
