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
    
    public partial class LTC_VITALSIGN
    {
        public long SEQNO { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> SBP { get; set; }
        public Nullable<int> DBP { get; set; }
        public Nullable<int> PULSE { get; set; }
        public Nullable<decimal> BODYTEMP { get; set; }
        public Nullable<int> BREATHE { get; set; }
        public Nullable<int> OXYGEN { get; set; }
        public Nullable<decimal> BLOODSUGAR { get; set; }
        public string BSTYPE { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public string COMA { get; set; }
        public Nullable<int> PAIN { get; set; }
        public Nullable<int> BOWELS { get; set; }
        public string CLASSTYPE { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public string ORGID { get; set; }
    }
}
