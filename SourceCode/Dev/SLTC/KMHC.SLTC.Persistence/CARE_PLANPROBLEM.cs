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
    
    public partial class CARE_PLANPROBLEM
    {
        public CARE_PLANPROBLEM()
        {
            this.CARE_PLANACTIVITY = new HashSet<CARE_PLANACTIVITY>();
            this.CARE_PLANCHECKPOINT = new HashSet<CARE_PLANCHECKPOINT>();
            this.CARE_PLANDATA = new HashSet<CARE_PLANDATA>();
            this.CARE_PLANEVAL = new HashSet<CARE_PLANEVAL>();
            this.CARE_PLANFOCUS = new HashSet<CARE_PLANFOCUS>();
            this.CARE_PLANGOAL = new HashSet<CARE_PLANGOAL>();
            this.CARE_PLANREASON = new HashSet<CARE_PLANREASON>();
            this.CARE_PLANTRAIN = new HashSet<CARE_PLANTRAIN>();
        }
    
        public int CP_NO { get; set; }
        public string LEVELPR { get; set; }
        public string CATEGORY { get; set; }
        public string DIAPR { get; set; }
    
        public virtual ICollection<CARE_PLANACTIVITY> CARE_PLANACTIVITY { get; set; }
        public virtual ICollection<CARE_PLANCHECKPOINT> CARE_PLANCHECKPOINT { get; set; }
        public virtual ICollection<CARE_PLANDATA> CARE_PLANDATA { get; set; }
        public virtual ICollection<CARE_PLANEVAL> CARE_PLANEVAL { get; set; }
        public virtual ICollection<CARE_PLANFOCUS> CARE_PLANFOCUS { get; set; }
        public virtual ICollection<CARE_PLANGOAL> CARE_PLANGOAL { get; set; }
        public virtual ICollection<CARE_PLANREASON> CARE_PLANREASON { get; set; }
        public virtual ICollection<CARE_PLANTRAIN> CARE_PLANTRAIN { get; set; }
    }
}
