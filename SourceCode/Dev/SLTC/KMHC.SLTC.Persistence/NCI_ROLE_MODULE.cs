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
    
    public partial class NCI_ROLE_MODULE
    {
        public string MODULEID { get; set; }
        public string ROLEID { get; set; }
        public string MODULESETTING { get; set; }
    
        public virtual NCI_MODULES NCI_MODULES { get; set; }
        public virtual NCI_ROLE NCI_ROLE { get; set; }
    }
}