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
    
    public partial class LTC_MEDICINE
    {
        public LTC_MEDICINE()
        {
            this.LTC_VISITPRESCRIPTION = new HashSet<LTC_VISITPRESCRIPTION>();
        }
    
        public int MEDID { get; set; }
        public string MEDCODE { get; set; }
        public string CHNNAME { get; set; }
        public string ENGNAME { get; set; }
        public string SIDEEFFECT { get; set; }
        public string MEDKIND { get; set; }
        public string MEDICOLOR { get; set; }
        public string MEDIFACADE { get; set; }
        public string SPECDESC { get; set; }
        public string USEDESC { get; set; }
        public string COMMCODE { get; set; }
        public string MEDTYPE { get; set; }
        public string MEDPICT { get; set; }
        public string INSNO { get; set; }
        public string HOSPNO { get; set; }
        public string ORGID { get; set; }
    
        public virtual ICollection<LTC_VISITPRESCRIPTION> LTC_VISITPRESCRIPTION { get; set; }
    }
}
