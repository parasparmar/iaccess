//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iAccess.Models
{
    using System;
    
    public partial class GetEmployeeLeaveRequestes_Result
    {
        public int EMPCODE { get; set; }
        public string NAME { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string LEAVE_REASON { get; set; }
        public System.DateTime APPLIED_ON { get; set; }
        public string LEVEL1_ACTION { get; set; }
        public Nullable<int> LEVEL1_ACTIONED_BY { get; set; }
        public string LEVEL1_COMMENTS { get; set; }
        public string LEVEL1_ACTIONED_ON { get; set; }
        public string LEVEL2_ACTION { get; set; }
        public Nullable<int> LEVEL2_ACTIONED_BY { get; set; }
        public string LEVEL2_COMMENTS { get; set; }
        public string LEVEL2_ACTIONED_ON { get; set; }
        public string CANCELDATE { get; set; }
        public int ID { get; set; }
        public string STATUS { get; set; }
    }
}
