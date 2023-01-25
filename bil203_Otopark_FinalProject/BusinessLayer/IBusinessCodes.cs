using bil203_Otopark_FinalProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bil203_Otopark_FinalProject.BusinessLayer
{
   public interface IBusinessCodes
    {
        bool GirisYap(string username , string password);
        List<AraclarModel> AraclariGetir();
        AraclarModel IdBilgisineGoreGetir(int id);
        bool AracGuncelle(AraclarModel arac);
        bool AracSil(int id);
        AraclarModel AracEkle(AraclarModel arac);
        int AktifAracSayisiGetir();
        int OrtalamaSaatGetir();
    }
}
