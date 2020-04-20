using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCS.Web.Controllers.api
{
    public class BaseApiController : ApiController
    {
        public static RCSService.RCSServiceClient RSCServiceClient;
    }
}
