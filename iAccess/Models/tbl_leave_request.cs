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
    using System.Collections.Generic;
    
    public partial class tbl_leave_request
    {
        public int id { get; set; }
        public int ecn { get; set; }
        public System.DateTime from_date { get; set; }
        public System.DateTime to_date { get; set; }
        public string leave_reason { get; set; }
        public System.DateTime applied_on { get; set; }
        public Nullable<byte> Level1_Action { get; set; }
        public Nullable<int> Level1_actioned_by { get; set; }
        public string Level1_comments { get; set; }
        public Nullable<System.DateTime> Level1_actioned_on { get; set; }
        public Nullable<byte> Level2_Action { get; set; }
        public Nullable<int> Level2_actioned_by { get; set; }
        public string Level2_comments { get; set; }
        public Nullable<System.DateTime> Level2_actioned_on { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string cancel_reason { get; set; }
    }
}