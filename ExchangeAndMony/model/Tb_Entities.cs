//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeAndMony.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Entities
    {
        public int EntitiesNumber { get; set; }
        public Nullable<int> UserNumbers { get; set; }
        public string Side { get; set; }
        public string Description { get; set; }
        public string Agent { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
    
        public virtual Tb_Users Tb_Users { get; set; }
    }
}
