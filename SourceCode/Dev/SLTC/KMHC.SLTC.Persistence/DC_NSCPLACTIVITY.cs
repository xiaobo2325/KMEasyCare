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
    
    public partial class DC_NSCPLACTIVITY
    {
        public long ID { get; set; }
        public Nullable<long> SEQNO { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string CPLACTIVITY { get; set; }
        public Nullable<long> FINISHFLAG { get; set; }
        public Nullable<System.DateTime> FINISHDATE { get; set; }
        public string UNFINISHREASON { get; set; }
    
        public virtual DC_REGCPL DC_REGCPL { get; set; }
    }
}
