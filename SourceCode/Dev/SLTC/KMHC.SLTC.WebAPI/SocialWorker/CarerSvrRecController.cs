﻿using KM.Common;
using KMHC.Infrastructure;
using KMHC.SLTC.Business.Entity.Base;
using KMHC.SLTC.Business.Entity.Filter;
using KMHC.SLTC.Business.Entity.Model;
using KMHC.SLTC.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;


namespace KMHC.SLTC.WebAPI.SocialWorker
{
    [RoutePrefix("api/carersvrs")]
    public class CarerSvrRecController:BaseController
    {
        ISocialWorkerManageService service = IOCContainer.Instance.Resolve<ISocialWorkerManageService>();

        //GET api/SubsidyRec
        [Route(""), HttpGet]
        public IHttpActionResult Query(int feeNo, int CurrentPage, int PageSize)
        {
            BaseRequest<CaresvrRecFilter> request = new BaseRequest<CaresvrRecFilter>();

            request.CurrentPage = CurrentPage;

            request.PageSize = PageSize;

            request.Data.FeeNo = feeNo;

            var response = service.QueryCareSvrRec(request);

            return Ok(response);
        }
        [Route("")]
        public IHttpActionResult Post(CaresvrRecModel baseRequest)
        {
            baseRequest.CreateBy = SecurityHelper.CurrentPrincipal.EmpNo;
            baseRequest.CreateDate = DateTime.Now;
            baseRequest.OrgId = SecurityHelper.CurrentPrincipal.OrgId;

            var response = service.SaveCareSvr(baseRequest);
            return Ok(response);
        }
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            var response = service.GetCareSvrById(id);
            return Ok(response);
        }
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            var response = service.DeleteCareSvrById(id);
            return Ok(response);
        }
    }
}