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
    
    public partial class Tb_Currencise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Currencise()
        {
            this.Tb_CurrenciesPrices = new HashSet<Tb_CurrenciesPrices>();
            this.Tb_Transfar = new HashSet<Tb_Transfar>();
        }
    
        public int CurrencyNumbers { get; set; }
        public Nullable<int> UserNumbers { get; set; }
        public string UserName { get; set; }
        public string CurrencyName { get; set; }
        public string ArabicSymbol { get; set; }
        public string EnglishSymbol { get; set; }
        public string ForeignSymbol { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_CurrenciesPrices> Tb_CurrenciesPrices { get; set; }
        public virtual Tb_Users Tb_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Transfar> Tb_Transfar { get; set; }
    }
}