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
    
    public partial class LTC_HOMECARESVRREC
    {
        public long ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public Nullable<System.DateTime> RECRDATE { get; set; }
        public string RECORDBY { get; set; }
        public string ATTENDTYPE { get; set; }
        public string LEAVEREASON { get; set; }
        public Nullable<decimal> BODYTEMP { get; set; }
        public Nullable<int> SBP { get; set; }
        public Nullable<int> DBP { get; set; }
        public Nullable<int> BREATHE { get; set; }
        public Nullable<int> PULSE { get; set; }
        public Nullable<bool> MOUTHCARE { get; set; }
        public Nullable<bool> TEETHCARE { get; set; }
        public Nullable<bool> DENTURECARE { get; set; }
        public Nullable<bool> GARGLE { get; set; }
        public Nullable<bool> MOUTHCHECK { get; set; }
        public Nullable<bool> WOUNDCARE { get; set; }
        public string WOUNDCAREREASON { get; set; }
        public Nullable<bool> BODYCARE { get; set; }
        public Nullable<bool> CUTNAILS { get; set; }
        public Nullable<bool> SHAVE { get; set; }
        public Nullable<bool> CHANGECLOTH { get; set; }
        public Nullable<bool> CUTHAIR { get; set; }
        public Nullable<bool> WASHHAIR { get; set; }
        public Nullable<bool> BATH { get; set; }
        public string LUNCH { get; set; }
        public string LUNCHMEAT { get; set; }
        public Nullable<bool> GENERALDIET { get; set; }
        public Nullable<bool> SOFTDIET { get; set; }
        public Nullable<bool> BROKENDIET { get; set; }
        public Nullable<bool> LOWSUGARDIET { get; set; }
        public Nullable<bool> LOWSODIUMDIET { get; set; }
        public Nullable<bool> LOWOILDIET { get; set; }
        public string SNACK { get; set; }
        public Nullable<int> WATERAMT { get; set; }
        public string EATASSIST { get; set; }
        public Nullable<bool> MEDICATION_BB { get; set; }
        public Nullable<bool> MEDICATION { get; set; }
        public Nullable<bool> MEDICATION_AB { get; set; }
        public Nullable<bool> MEDICATION_BL { get; set; }
        public Nullable<bool> MEDICATION_AL { get; set; }
        public Nullable<bool> MEDICATION_AS { get; set; }
        public Nullable<bool> EYEDROPS { get; set; }
        public Nullable<int> EYEDROPS_TIMES { get; set; }
        public Nullable<bool> GETDRUGS { get; set; }
        public Nullable<bool> VISITDOCTOR { get; set; }
        public string VISITHOSPITAL { get; set; }
        public Nullable<int> URINETIMES { get; set; }
        public Nullable<int> DIAPERCHANGETIMES { get; set; }
        public Nullable<int> DEFECTIONTIMES { get; set; }
        public string DISCHARGESTATE { get; set; }
        public Nullable<bool> MOODSTABLE { get; set; }
        public Nullable<bool> MOODANXIOUS { get; set; }
        public Nullable<bool> MOODDYSPHORIA { get; set; }
        public Nullable<bool> MOODANGER { get; set; }
        public Nullable<bool> MOODAPATHY { get; set; }
        public Nullable<bool> SUNDOWNSYNDROME { get; set; }
        public Nullable<bool> MOODOTHERS { get; set; }
        public string MOODOTHERSDESC { get; set; }
        public string NOONBREAK { get; set; }
        public string NOONSHUTTLE { get; set; }
        public string AFTERNOONSHUTTLE { get; set; }
        public Nullable<bool> RELATIVESVISIT { get; set; }
        public Nullable<bool> RELATIVESTALK { get; set; }
        public Nullable<bool> RELATIVESTEL { get; set; }
        public Nullable<bool> CONTACTBOOK { get; set; }
        public string AM_ACTIVITY { get; set; }
        public string AM_A_RARTICIPATE { get; set; }
        public string AM_ATTENTION { get; set; }
        public string PM_ACTIVITY { get; set; }
        public string PM_A_PARTICIPATE { get; set; }
        public string PM_ATTENTION { get; set; }
        public string PERSONALACTIVITY { get; set; }
        public string EQUIPMENTUSE { get; set; }
        public string SPECIALCASE { get; set; }
        public Nullable<bool> PASTYDIET { get; set; }
        public Nullable<bool> OTHERDIET { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string ORGID { get; set; }
    }
}
