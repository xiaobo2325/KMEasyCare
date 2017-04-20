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
    
    public partial class LTC_RESIDENTBALANCE
    {
        public LTC_RESIDENTBALANCE()
        {
            this.LTC_PRECHARGE = new HashSet<LTC_PRECHARGE>();
            this.LTC_RESIDENTBALANCEREFUND = new HashSet<LTC_RESIDENTBALANCEREFUND>();
        }
    
        public string BALANCEID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public decimal DEPOSIT { get; set; }
        public decimal BLANCE { get; set; }
        public Nullable<decimal> TOTALPAYMENT { get; set; }
        public Nullable<decimal> TOTALCOST { get; set; }
        public Nullable<decimal> TOTALNCIPAY { get; set; }
        public Nullable<decimal> TOTALNCIOVERSPEND { get; set; }
        public bool ISHAVENCI { get; set; }
        public Nullable<decimal> NCIPAYLEVEL { get; set; }
        public Nullable<decimal> NCIPAYSCALE { get; set; }
        public int STATUS { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual ICollection<LTC_PRECHARGE> LTC_PRECHARGE { get; set; }
        public virtual ICollection<LTC_RESIDENTBALANCEREFUND> LTC_RESIDENTBALANCEREFUND { get; set; }
    }
}
