using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunlerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunlerService.svc or UrunlerService.svc.cs at the Solution Explorer and start debugging.
    public class UrunlerService : IUrunlerService
    {
        public string DoWork()
        {
            return "Merhaba WCF Service";
        }
        NorthwindEntities db = new NorthwindEntities();

        public List<UrunDTO> UrunListesi()
        {
            return db.Urunler.Select(x => new UrunDTO
            {
                BirimdekiMiktar = x.BirimdekiMiktar,
                BirimFiyati = x.BirimFiyati,
                EnAzYenidenSatisMikatari = x.EnAzYenidenSatisMikatari,
                HedefStokDuzeyi = x.HedefStokDuzeyi,
                Sonlandi = x.Sonlandi,
                UrunAdi = x.UrunAdi,
                TedarikciID = x.TedarikciID,
                UrunID = x.UrunID,
                YeniSatis = x.YeniSatis
            }).ToList();
        }
    }
}
