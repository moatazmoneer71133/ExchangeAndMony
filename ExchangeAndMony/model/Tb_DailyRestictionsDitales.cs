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
    
    public partial class Tb_DailyRestictionsDitales
    {
        public int Numbers { get; set; }
        public Nullable<int> ConstNumbers { get; set; }
        public Nullable<System.DateTime> ConstDate { get; set; }
        public string Currency { get; set; }
        public string AccountNameMadin { get; set; }
        public string AccountNameDain { get; set; }
        public Nullable<int> AccountMadin { get; set; }
        public Nullable<int> AccountDain { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> AmountMadin { get; set; }
        public Nullable<int> AmountDain { get; set; }
        public string Statements { get; set; }
    
        public virtual Tb_DailyrestictionsHead Tb_DailyrestictionsHead { get; set; }
    }
}
