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
    
    public partial class DC_IPDREG
    {
        public DC_IPDREG()
        {
            this.DC_REFERRALLISTS = new HashSet<DC_REFERRALLISTS>();
        }
    
        public long FEENO { get; set; }
        public string REGNO { get; set; }
        public Nullable<System.DateTime> INDATE { get; set; }
        public string STATIONCODE { get; set; }
        public string IPDFLAG { get; set; }
        public string RESIDENTNO { get; set; }
        public string SOCIALWORKER { get; set; }
        public string NURSEAIDES { get; set; }
        public string NURSENO { get; set; }
        public Nullable<bool> CLOSEFLAG { get; set; }
        public string CLOSEREASON { get; set; }
        public Nullable<System.DateTime> OUTDATE { get; set; }
        public string PROVIDESERVICE { get; set; }
        public string SVRCONTENT { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CHECKDATE { get; set; }
        public string CHECKEDBY { get; set; }
        public string ORGID { get; set; }
    
        public virtual DC_REGFILE DC_REGFILE { get; set; }
        public virtual ICollection<DC_REFERRALLISTS> DC_REFERRALLISTS { get; set; }
    }
}
