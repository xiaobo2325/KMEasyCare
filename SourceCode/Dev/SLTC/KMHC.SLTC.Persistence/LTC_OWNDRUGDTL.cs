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
    
    public partial class LTC_OWNDRUGDTL
    {
        public int ID { get; set; }
        public int OWNDRUGID { get; set; }
        public int DRUGID { get; set; }
        public string MCDRUGCODE { get; set; }
        public string NSDRUGCODE { get; set; }
        public string CNNAME { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public string UNITS { get; set; }
        public string MANUFACTURER { get; set; }
        public string BATCHNO { get; set; }
        public string COMMENT { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    }
}
