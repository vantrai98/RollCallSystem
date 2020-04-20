using RCS.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RCS.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RCSService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RCSService.svc or RCSService.svc.cs at the Solution Explorer and start debugging.
    public class RCSService : IRCSService
    {
        private RCSEntities Context = new RCSEntities();
        public Test Test()
        {
            var a = Context.Tests.FirstOrDefault();

            return a;
        }
    }
}
