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
    
    public partial class LTC_BEDSORECHGREC
    {
        public long ID { get; set; }
        public Nullable<long> SEQ { get; set; }
        public Nullable<System.DateTime> ECALDATE { get; set; }
        public string WOUNDPART { get; set; }
        public string DEGREE { get; set; }
        public string SIZE_L { get; set; }
        public string SIZE_W { get; set; }
        public string SIZE_D { get; set; }
        public string WOUNDDIRECTION { get; set; }
        public string WOUNDDEPTH { get; set; }
        public string WOUNDCOLOR { get; set; }
        public string SKINDESC { get; set; }
        public string SECRETIONCOLOR { get; set; }
        public string SECRETIONNATURE { get; set; }
        public string SECRETIONAMT { get; set; }
        public string NURSE { get; set; }
        public string DRESSING { get; set; }
        public string TREATEMENT { get; set; }
        public string PICTURE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
    
        public virtual LTC_BEDSOREREC LTC_BEDSOREREC { get; set; }
    }
}
