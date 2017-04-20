//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class LTC_VISITDOCRECORDS
    {
        public LTC_VISITDOCRECORDS()
        {
            this.LTC_VISITPRESCRIPTION = new HashSet<LTC_VISITPRESCRIPTION>();
        }
    
        public int SEQNO { get; set; }
        public Nullable<System.DateTime> VISITDATE { get; set; }
        public string VISITTYPE { get; set; }
        public string RECORDBY { get; set; }
        public string VISITHOSP { get; set; }
        public string VISITDEPT { get; set; }
        public string VISITDOCTOR { get; set; }
        public string VISITREASON { get; set; }
        public Nullable<bool> INFECTFLAG { get; set; }
        public Nullable<bool> PLANVISITFLAG { get; set; }
        public Nullable<int> TAKEDAYS { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public string DISEASETYPE { get; set; }
        public string DISEASENAME { get; set; }
        public string SYMPTOMS { get; set; }
        public string OBJECTIVEDESCRIP { get; set; }
        public string DIAGNOSTICEVAL { get; set; }
        public string TREATMENT { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<bool> NEXTVISITFLAG { get; set; }
        public string NEXTVISITHINT { get; set; }
        public string PREREGINFO { get; set; }
        public Nullable<int> INTERVALDAY { get; set; }
        public Nullable<System.DateTime> NEXTVISITDATE { get; set; }
        public string NEXTVISITTYPE { get; set; }
        public string ORGID { get; set; }
        public string INFECTVISITREASON { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
    
        public virtual ICollection<LTC_VISITPRESCRIPTION> LTC_VISITPRESCRIPTION { get; set; }
    }
}
