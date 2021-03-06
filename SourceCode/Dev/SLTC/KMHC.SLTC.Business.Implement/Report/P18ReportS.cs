﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KM.Common;
using KMHC.Infrastructure;
using KMHC.Infrastructure.Word;
using KMHC.SLTC.Business.Entity.Base;
using KMHC.SLTC.Business.Entity.Filter;
using KMHC.SLTC.Business.Entity.Model;
using KMHC.SLTC.Business.Entity.Report;
using KMHC.SLTC.Business.Interface;

namespace KMHC.SLTC.Business.Implement.Report
{
    public class P18ReportS : BaseReport
    {

        protected override void Operation(WordDocument doc)
        {
            long Id = ParamId;
            IReportManageService reportManageService = IOCContainer.Instance.Resolve<IReportManageService>();
            INursingWorkstationService nursingWorkstationService = IOCContainer.Instance.Resolve<INursingWorkstationService>();
            IDictManageService dictManageService = IOCContainer.Instance.Resolve<IDictManageService>();
            ICarePlanReportService carePlanservice = IOCContainer.Instance.Resolve<ICarePlanReportService>();
            BaseRequest<NursingRecFilter> nursingRecFilter = new BaseRequest<NursingRecFilter>();
            nursingRecFilter.CurrentPage = 1;
            nursingRecFilter.PageSize = 1000;
           // nursingRecFilter.Data.PrintFlag = true;
            nursingRecFilter.Data.Id = Id;
            var response = nursingWorkstationService.QueryNursingRec(nursingRecFilter);
            var residentInfo = carePlanservice.GetExportResidentInfo(response.Data[0].FeeNo.Value);
            if (residentInfo != null)
            {
                doc.ReplaceText("Org", residentInfo.Org ?? "");
                doc.ReplaceText("Name", residentInfo.Name ?? "");
                doc.ReplaceText("Sex", residentInfo.Sex ?? "未填");
                doc.ReplaceText("Age", residentInfo.Age.HasValue ? residentInfo.Age.ToString() : "");
                doc.ReplaceText("FeeNo", residentInfo.ResidentNo);
                doc.ReplaceText("Floor", residentInfo.Floor ?? "");
                doc.ReplaceText("RoomNo", residentInfo.RoomNo ?? "");
            }
            else
            {
                doc.ReplaceText("Org", "");
                doc.ReplaceText("Name", "");
                doc.ReplaceText("Sex", "未填");
                doc.ReplaceText("Age", "");
                doc.ReplaceText("FeeNo", "");
                doc.ReplaceText("Floor", "");
                doc.ReplaceText("RoomNo", "");
            }
            CodeFilter codeFilter = new CodeFilter { ItemTypes = new string[] { "J00.005" } };
            var dict = (List<CodeValue>)dictManageService.QueryCode(codeFilter).Data;
            DataTable dt = new DataTable();
            dt.Columns.Add("c1");
            dt.Columns.Add("c2");
            dt.Columns.Add("c3");
            dt.Columns.Add("c4");
            if (response.Data != null)
            {
                foreach (var item in response.Data)
                {
                    var dr = dt.NewRow();
                    var findItem = dict.Find(it => it.ItemType == "J00.005" && it.ItemCode == item.ClassType);
                    dr["c1"] = item.RecordDate.HasValue ? item.RecordDate.Value.ToString("yyyy-MM-dd") : "";
                    dr["c2"] = string.Format("{0} {1}{2}", item.RecordDate.HasValue ? item.RecordDate.Value.ToString("HH:mm") : "", item.ClassType, findItem != null ? findItem.ItemName : "");
                    dr["c3"] = item.Content;
                    dr["c4"] = item.RecordNameBy;
                    dt.Rows.Add(dr);
                }
            }
            doc.FillTable(0, dt, "", "", 1);
            dt.Dispose();
        }
    }
}
