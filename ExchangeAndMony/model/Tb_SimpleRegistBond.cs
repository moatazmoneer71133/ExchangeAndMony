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
    
    public partial class Tb_SimpleRegistBond
    {
        public int BondNumber { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> UserNumbers { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public string Currency { get; set; }
        public Nullable<int> AmountMadin { get; set; }
        public Nullable<int> AmountDain { get; set; }
        public Nullable<int> AccountNumberMadin { get; set; }
        public Nullable<int> AccountNumberDain { get; set; }
        public string AccountNameMadin { get; set; }
        public string AccountNameDain { get; set; }
        public string CurrencyMadin { get; set; }
        public string CurrencyDain { get; set; }
        public Nullable<int> ExchangePrice { get; set; }
        public string RegistStatus { get; set; }
        public Nullable<System.DateTime> TheDate { get; set; }
        public string Note { get; set; }
    
        public virtual Tb_Users Tb_Users { get; set; }
    }
}
