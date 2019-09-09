using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
namespace WebService
{
    /// <summary>
    /// Summary description for UrunlerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UrunlerService : System.Web.Services.WebService
    {
        NorthwindEntities db = new NorthwindEntities();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public Kimlik KimlikBilgisi { get; set; }
        [WebMethod]
        [SoapHeader("KimlikBilgisi")]
        public List<UrunDTO> UrunlerListesi()
        {
            if (KimlikBilgisi.KullaniciAdi == "Admin" && KimlikBilgisi.Parola == "123")
            {
                return db.Urunlers.Select(x => new UrunDTO
            {
                BirimdekiMiktar = x.BirimdekiMiktar,
                BirimFiyati = x.BirimFiyati,
                EnAzYenidenSatisMikatari = x.EnAzYenidenSatisMikatari,
                HedefStokDuzeyi = x.HedefStokDuzeyi,
                TedarikciID = x.TedarikciID,
                UrunID = x.UrunID,
                YeniSatis = x.YeniSatis
            }).ToList();
            }
            else
            {
                return null;
            }

        }
    }
}
