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
    
    public partial class LTC_WORKITEM
    {
        public LTC_WORKITEM()
        {
            this.LTC_LOOKOVER = new HashSet<LTC_LOOKOVER>();
            this.LTC_WORKSUBITEM = new HashSet<LTC_WORKSUBITEM>();
        }
    
        public string ITEMCODE { get; set; }
        public string ITEMNAME { get; set; }
        public string ITEMTYPE { get; set; }
        public Nullable<int> ORDER { get; set; }
        public string DESCRIPTION { get; set; }
    
        public virtual ICollection<LTC_LOOKOVER> LTC_LOOKOVER { get; set; }
        public virtual ICollection<LTC_WORKSUBITEM> LTC_WORKSUBITEM { get; set; }
    }
}
