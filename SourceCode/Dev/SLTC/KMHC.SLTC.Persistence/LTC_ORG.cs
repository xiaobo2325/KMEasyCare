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
    
    public partial class LTC_ORG
    {
        public LTC_ORG()
        {
            this.LTC_USERS = new HashSet<LTC_USERS>();
        }
    
        public string ORGID { get; set; }
        public string GROUPID { get; set; }
        public string ORGNAME { get; set; }
        public string ORGTYPE { get; set; }
        public string NSNO { get; set; }
        public string GOVID { get; set; }
        public string RESPONSIBLE { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public Nullable<int> BEDCOUNT { get; set; }
        public string EMAIL { get; set; }
        public string WEBSITE { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual LTC_ACTIVEPERIOD LTC_ACTIVEPERIOD { get; set; }
        public virtual LTC_GROUP LTC_GROUP { get; set; }
        public virtual ICollection<LTC_USERS> LTC_USERS { get; set; }
    }
}
