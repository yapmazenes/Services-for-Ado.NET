//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nakliyeciler
    {
        public Nakliyeciler()
        {
            this.Satislars = new HashSet<Satislar>();
        }
    
        public int NakliyeciID { get; set; }
        public string SirketAdi { get; set; }
        public string Telefon { get; set; }
    
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}
