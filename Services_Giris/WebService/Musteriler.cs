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
    
    public partial class Musteriler
    {
        public Musteriler()
        {
            this.Satislars = new HashSet<Satislar>();
        }
    
        public string MusteriID { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
    
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}
