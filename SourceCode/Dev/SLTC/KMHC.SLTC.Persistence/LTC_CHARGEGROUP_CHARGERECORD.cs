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
    
    public partial class LTC_CHARGEGROUP_CHARGERECORD
    {
        public int CGCRID { get; set; }
        public string CHARGEGROUPID { get; set; }
        public long FEENO { get; set; }
        public Nullable<decimal> TOTALMONEY { get; set; }
        public Nullable<int> QUANTITY { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual LTC_CHARGEGROUP LTC_CHARGEGROUP { get; set; }
    }
}
