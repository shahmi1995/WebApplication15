//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication15.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int No_Transaction { get; set; }
        public Nullable<int> Stock_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Total_price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Emp_ID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Stock Stock { get; set; }
    }
}