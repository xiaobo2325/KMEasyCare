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
    
    public partial class LTC_CHECKTYPE
    {
        public LTC_CHECKTYPE()
        {
            this.LTC_CHECKITEM = new HashSet<LTC_CHECKITEM>();
        }
    
        public string TYPECODE { get; set; }
        public string TYPENAME { get; set; }
    
        public virtual ICollection<LTC_CHECKITEM> LTC_CHECKITEM { get; set; }
    }
}
