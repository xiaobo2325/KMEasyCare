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
    
    public partial class LTC_CONSULTCALLBACK
    {
        public long ID { get; set; }
        public Nullable<long> CONSULTRECID { get; set; }
        public Nullable<System.DateTime> CALLBACKTIME { get; set; }
        public string INTERVIEWEE { get; set; }
        public string INTERVIEWREC { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
    
        public virtual LTC_CONSULTREC LTC_CONSULTREC { get; set; }
    }
}
