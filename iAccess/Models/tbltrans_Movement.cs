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
    
    public partial class tbltrans_Movement
    {
        public int Id { get; set; }
        public Nullable<int> FromDptLinkMstId { get; set; }
        public Nullable<int> ToDptLinkMstId { get; set; }
        public Nullable<int> FromMgr { get; set; }
        public Nullable<int> ToMgr { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<int> Type { get; set; }
        public byte State { get; set; }
        public Nullable<int> InitBy { get; set; }
        public System.DateTime InitOn { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> UpdaterID { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
