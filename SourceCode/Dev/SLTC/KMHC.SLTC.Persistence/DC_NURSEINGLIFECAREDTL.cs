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
    
    public partial class DC_NURSEINGLIFECAREDTL
    {
        public long SEQNO { get; set; }
        public Nullable<long> ID { get; set; }
        public string ACTIVITY9 { get; set; }
        public string ACTIVITY11 { get; set; }
        public string ACTIVITY14 { get; set; }
        public string ACTIVITY15 { get; set; }
        public string ACTIVITY16 { get; set; }
        public Nullable<decimal> BODYTEMPERATURE { get; set; }
        public Nullable<int> PULSE { get; set; }
        public Nullable<int> BREATH { get; set; }
        public Nullable<int> SBP { get; set; }
        public Nullable<int> DBP { get; set; }
        public string MEDICINE { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public string DAYOFWEEK { get; set; }
        public string HOLIDAYFLAG { get; set; }
    
        public virtual DC_NURSEINGLIFECAREREC DC_NURSEINGLIFECAREREC { get; set; }
    }
}
