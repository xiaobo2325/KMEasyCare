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
    
    public partial class LTC_GROUP
    {
        public LTC_GROUP()
        {
            this.LTC_ORG = new HashSet<LTC_ORG>();
        }
    
        public string GROUPID { get; set; }
        public string GROUPNAME { get; set; }
        public string ADDRESS { get; set; }
    
        public virtual ICollection<LTC_ORG> LTC_ORG { get; set; }
    }
}
