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
    
    public partial class LTC_IPDVERIFY
    {
        public int ID { get; set; }
        public long FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public Nullable<decimal> SUBSIDYAMT { get; set; }
        public string SUBSIDYWAY { get; set; }
        public string SUBSIDYUNIT { get; set; }
        public Nullable<decimal> FEERATE { get; set; }
        public string APPLYDOCNO { get; set; }
        public Nullable<System.DateTime> APPLYDATE { get; set; }
        public Nullable<System.DateTime> EXPIREDATE { get; set; }
        public string APPROVEDOCNO { get; set; }
        public Nullable<System.DateTime> APPROVEDATE { get; set; }
        public string INSTYPE { get; set; }
        public string BANKNAME { get; set; }
        public string BANKACCOUNTNO { get; set; }
        public string OTHERACCOUNTNO { get; set; }
        public Nullable<decimal> DEPOSITBALANCE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string ORGID { get; set; }
    }
}
