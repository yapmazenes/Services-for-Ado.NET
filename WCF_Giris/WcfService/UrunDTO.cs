using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class UrunDTO
    {
        [DataMember]
        public int UrunID { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public Nullable<int> TedarikciID { get; set; }
        [DataMember]
        public Nullable<int> KategoriID { get; set; }
        [DataMember]
        public string BirimdekiMiktar { get; set; }
        [DataMember]
        public Nullable<decimal> BirimFiyati { get; set; }
        [DataMember]
        public Nullable<short> HedefStokDuzeyi { get; set; }
        [DataMember]
        public Nullable<short> YeniSatis { get; set; }
        [DataMember]
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        [DataMember]
        public bool Sonlandi { get; set; }
    }
}