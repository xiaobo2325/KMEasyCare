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
    
    public partial class LTC_PINMONEY
    {
        public int ID { get; set; }
        public string IENO { get; set; }
        public string ITEMSUMMARY { get; set; }
        public string IETPYE { get; set; }
        public Nullable<decimal> COST { get; set; }
        public Nullable<System.DateTime> IEDATE { get; set; }
        public Nullable<System.DateTime> FACTDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public int REGNO { get; set; }
        public long FEENO { get; set; }
        public string ORGID { get; set; }
    }
}