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
    
    public partial class Tb_AccountStop
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> UserNumbers { get; set; }
        public string ReasonStop { get; set; }
        public string Currency { get; set; }
        public string Note { get; set; }
    
        public virtual Tb_Users Tb_Users { get; set; }
    }
}
