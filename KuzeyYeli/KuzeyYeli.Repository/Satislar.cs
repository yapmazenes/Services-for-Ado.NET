//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyYeli.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satislar
    {
        public Satislar()
        {
            this.SatisDetaylaris = new HashSet<SatisDetaylari>();
        }
    
        public int SatisID { get; set; }
        public string MusteriID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public Nullable<System.DateTime> OdemeTarihi { get; set; }
        public Nullable<System.DateTime> SevkTarihi { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> NakliyeUcreti { get; set; }
        public string SevkAdi { get; set; }
        public string SevkAdresi { get; set; }
        public string SevkSehri { get; set; }
        public string SevkBolgesi { get; set; }
        public string SevkPostaKodu { get; set; }
        public string SevkUlkesi { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
        public virtual Nakliyeciler Nakliyeciler { get; set; }
        public virtual Personeller Personeller { get; set; }
        public virtual ICollection<SatisDetaylari> SatisDetaylaris { get; set; }
    }
}
