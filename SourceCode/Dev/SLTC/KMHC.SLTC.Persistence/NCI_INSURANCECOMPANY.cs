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
    
    public partial class NCI_INSURANCECOMPANY
    {
        public NCI_INSURANCECOMPANY()
        {
            this.NCI_INSURANCECOMPANYSTAFF = new HashSet<NCI_INSURANCECOMPANYSTAFF>();
        }
    
        public string ICID { get; set; }
        public string GOVID { get; set; }
        public string ICNAME { get; set; }
        public string ADDRESS { get; set; }
        public string CONTACT { get; set; }
        public string PHONE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual NCI_GOVERNMENT NCI_GOVERNMENT { get; set; }
        public virtual ICollection<NCI_INSURANCECOMPANYSTAFF> NCI_INSURANCECOMPANYSTAFF { get; set; }
    }
}
