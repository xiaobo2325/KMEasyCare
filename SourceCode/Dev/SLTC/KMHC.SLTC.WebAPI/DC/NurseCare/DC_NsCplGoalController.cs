﻿using KM.Common;
using KMHC.SLTC.Business.Entity.DC.Model;
using KMHC.SLTC.Business.Interface.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KMHC.SLTC.WebAPI.DC.NurseCare
{
    [RoutePrefix("api/DC_NSCPLGOAL")]
    public class DC_NsCplGoalController : BaseController
    {
        IDC_ResidentManageService service = IOCContainer.Instance.Resolve<IDC_ResidentManageService>();

        [Route(""), HttpGet]
        public IHttpActionResult get(long seqNo)
        {
            var response = service.QueryNsCplGoalp(seqNo);
            return Ok(response);
        }

        [Route("")]
        public IHttpActionResult post(NSCPLGOAL request)
        {
            var response = service.saveNsCplGoalp(request);
            return Ok(response);
        }
    }
}
