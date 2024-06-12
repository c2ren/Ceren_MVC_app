using Microsoft.AspNetCore.Mvc;
using Sube2.HelloMvc.Models;
using Sube2.HelloMvc.Models.ViewModels;

namespace Sube2.HelloMvc.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action
        {
            return View();
        }

        public ViewResult OgrenciDetay(int id)
        {
            var d = new Ders { Dersad = "Matematik", Dersid = 1, Kredi = 3 };
            var ogrt = new Ogretmen { Ad = "Ahmet", Soyad = "Mehmet", Bolum = "Bilgisayar" };


            Ogrenci ogr = null;
            if (id == 1)
            {
                ogr = new Ogrenci();
                ogr.Ad = "Ali";
                ogr.Soyad = "Veli";
                ogr.Numara = 123;
            }
            else if (id == 2)
            {
                ogr = new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = 456 };
            }
            ViewData["ogrenci"] = ogr;
            ViewBag.student = ogr;

            var ogrvm = new OgrViewModel { Ders = d, Ogretmen = ogrt, Ogrenci = ogr };

            return View(ogrvm);
        }

        public ViewResult OgrenciListe()
        {
            var lst = new List<Ogrenci> {
            new Ogrenci { Ad = "Ali", Soyad = "Veli", Numara = 123 },
            new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = 456 }
            };

            return View(lst);
        }
    }
}

//Controller->View veri taşıma
//ViewData:Bir koleksiyon yapısıdır. ViewData bir dictionary yapısıdır. Anahtar ve değer çiftlerinden oluşur.

//ViewBag: Arka planda ViewData koleksiyonunu kullanan,dynamic yapıda bir veri taşıma yapısıdır.

//ViewModel
