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
    
    public partial class DC_CAREPLANGOAL
    {
        public int CGNO { get; set; }
        public Nullable<int> CPNO { get; set; }
        public string DIAPR { get; set; }
        public string GOALP { get; set; }
    
        public virtual DC_CAREPLANPROBLEM DC_CAREPLANPROBLEM { get; set; }
    }
}
