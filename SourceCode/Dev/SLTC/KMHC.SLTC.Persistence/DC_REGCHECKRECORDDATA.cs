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
    
    public partial class DC_REGCHECKRECORDDATA
    {
        public long DATAID { get; set; }
        public Nullable<long> RECORDID { get; set; }
        public string CHECKITEMCODE { get; set; }
        public string CHECKITEMVALUE { get; set; }
        public string LOWBOUND { get; set; }
        public string UPBOUND { get; set; }
        public string SEVERITYNAME { get; set; }
    
        public virtual DC_REGCHECKRECORD DC_REGCHECKRECORD { get; set; }
    }
}
