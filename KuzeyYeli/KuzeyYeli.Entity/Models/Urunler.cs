//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyYeli.Entity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler
    {
        public Urunler()
        {
            this.SatisDetaylaris = new HashSet<SatisDetaylari>();
        }
    
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<short> HedefStokDuzeyi { get; set; }
        public Nullable<short> YeniSatis { get; set; }
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<SatisDetaylari> SatisDetaylaris { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
