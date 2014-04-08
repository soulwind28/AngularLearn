//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularLearn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UsersDetails = new HashSet<UsersDetail>();
            this.UsersDetails1 = new HashSet<UsersDetail>();
            this.UsersDetails2 = new HashSet<UsersDetail>();
        }
    
        public int UserID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public Nullable<System.DateTime> DateStarted { get; set; }
        public Nullable<System.DateTime> DateFinished { get; set; }
        public Nullable<int> EmploymentTypeID { get; set; }
        public Nullable<decimal> Hours { get; set; }
        public Nullable<int> AccessType { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedUserID { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedUserID { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> DirectorUserID { get; set; }
        public Nullable<int> ManagerUserID { get; set; }
        public Nullable<int> StateID { get; set; }
        public int TimezoneID { get; set; }
    
        public virtual ICollection<UsersDetail> UsersDetails { get; set; }
        public virtual ICollection<UsersDetail> UsersDetails1 { get; set; }
        public virtual ICollection<UsersDetail> UsersDetails2 { get; set; }
    }
}