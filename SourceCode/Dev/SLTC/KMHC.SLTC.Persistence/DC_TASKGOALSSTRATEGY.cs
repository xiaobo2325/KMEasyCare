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
    
    public partial class DC_TASKGOALSSTRATEGY
    {
        public long EVALPLANID { get; set; }
        public string QUESTIONTYPE { get; set; }
        public string CPDIA { get; set; }
        public string QUESTIONDESC { get; set; }
        public string TREATMENTGOAL { get; set; }
        public string QUESTIONANALYSIS { get; set; }
        public string PLANACTIVITY { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string RECORDBY { get; set; }
        public string CHECKDATE { get; set; }
        public string CHECKEDBY { get; set; }
        public string EVALUATIONVALUE { get; set; }
        public string UNFINISHREASON { get; set; }
        public long ID { get; set; }
        public Nullable<int> MAJORTYPE { get; set; }
    
        public virtual DC_SWREGEVALPLAN DC_SWREGEVALPLAN { get; set; }
    }
}
