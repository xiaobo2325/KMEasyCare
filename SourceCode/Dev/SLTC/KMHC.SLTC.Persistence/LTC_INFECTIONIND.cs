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
    
    public partial class LTC_INFECTIONIND
    {
        public LTC_INFECTIONIND()
        {
            this.LTC_INFECTIONSYMPOTM = new HashSet<LTC_INFECTIONSYMPOTM>();
            this.LTC_LABEXAMREC = new HashSet<LTC_LABEXAMREC>();
        }
    
        public long SEQNO { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public string IFCTYPE { get; set; }
        public Nullable<System.DateTime> IFCDATE { get; set; }
        public string RECORDBY { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string CATEGORY { get; set; }
        public Nullable<bool> H72FLAG { get; set; }
        public Nullable<bool> IFCFLAG { get; set; }
        public Nullable<bool> CATHETERFLAG { get; set; }
        public Nullable<decimal> ITEMSCORE { get; set; }
        public string SECTYPE { get; set; }
        public Nullable<System.DateTime> SECSTARTDATE { get; set; }
        public Nullable<System.DateTime> SECENDDATE { get; set; }
        public Nullable<int> SECDAYS { get; set; }
        public string CLINICALSYMPTOM { get; set; }
        public string DOCTORDIAG { get; set; }
        public Nullable<bool> B3ANTIFLAG { get; set; }
        public Nullable<bool> ANTITREATFLAG { get; set; }
        public string ANTITREATTYPE { get; set; }
        public string IMPROVEMENT { get; set; }
        public string DESCRIPTION { get; set; }
        public string ORGID { get; set; }
        public string ITEMNO { get; set; }
    
        public virtual ICollection<LTC_INFECTIONSYMPOTM> LTC_INFECTIONSYMPOTM { get; set; }
        public virtual ICollection<LTC_LABEXAMREC> LTC_LABEXAMREC { get; set; }
    }
}