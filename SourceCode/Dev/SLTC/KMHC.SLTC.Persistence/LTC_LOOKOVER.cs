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
    
    public partial class LTC_LOOKOVER
    {
        public long ID { get; set; }
        public Nullable<System.DateTime> LOOKOVERTIME { get; set; }
        public string ITEMCODE { get; set; }
        public string FLOORID { get; set; }
        public string LOOKOVERPHOTOS { get; set; }
        public string CONTENT { get; set; }
        public string RECORDBY { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDETELE { get; set; }
    
        public virtual LTC_WORKITEM LTC_WORKITEM { get; set; }
    }
}
