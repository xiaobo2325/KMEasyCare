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
    
    public partial class LTC_PAINBODYPART
    {
        public long ID { get; set; }
        public Nullable<long> SEQNO { get; set; }
        public string PAINPART { get; set; }
        public string PAINNATURE { get; set; }
        public string OCCURCHANCE { get; set; }
        public string OCCURREASON { get; set; }
        public string PAINSEVERITY_CURRENT { get; set; }
        public string PAINSEVERITY_MOST { get; set; }
        public string PAINSEVERITY_LOW { get; set; }
        public string PAINSEVERITY_BEAR { get; set; }
        public string PAINDEPTH { get; set; }
        public string PAINEXTENSION { get; set; }
        public string STARTPAIN { get; set; }
        public string PAINFREQUENCY { get; set; }
        public string PAINDURATION { get; set; }
        public string MOSTPAIN1DAY { get; set; }
        public string EASEPAINWAY { get; set; }
        public string PAINSERIOUSFACTOR { get; set; }
        public string SYMPTOM { get; set; }
        public string AFFECT_SLEEP { get; set; }
        public string AFFECT_ACTIVITY { get; set; }
        public string AFFECT_EATING { get; set; }
        public string AFFECT_ATTENTION { get; set; }
        public string AFFECT_EMOTION { get; set; }
        public string AFFECT_RELATIONS { get; set; }
        public string AFFECT_OTHERS { get; set; }
        public Nullable<bool> CANCELFLAG { get; set; }
        public Nullable<System.DateTime> CANCELDATE { get; set; }
        public string CANCELREASON { get; set; }
        public string PICTURE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
    
        public virtual LTC_PAINEVALREC LTC_PAINEVALREC { get; set; }
    }
}
