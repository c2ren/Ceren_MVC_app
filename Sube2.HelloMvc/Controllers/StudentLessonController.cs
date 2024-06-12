using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sube2.HelloMvc.Models;

namespace Sube2.HelloMvc.Controllers
{
    public class StudentLessonController : Controller
    {
        public IActionResult Index()
        {
            using (var ctx = new OkulDbContext())
            {
                var lst = ctx.Ogrenciler.ToList();
                return View(lst);
            }
        }

        [HttpGet]
        public ActionResult AddLesson(int Ogrenciid)
        {
            ViewBag.Ogrenciid = Ogrenciid;
            using (var ctx = new OkulDbContext())
            {
                var lst = ctx.Dersler.ToList();
                return View(lst);
            }
        }

        [HttpPost]
        public IActionResult AddLesson2(int Ogrenciid,int Dersid)
        {
            using (var ctx = new OkulDbContext())
            {

                var ogrenciDers = new OgrenciDers
                {
                    OgrenciId = Ogrenciid,
                    DersId = Dersid
                };

                ctx.OgrenciDersler.Add(ogrenciDers);
                ctx.SaveChanges();

                return RedirectToAction("Index");

            }

        }

        [HttpGet]
        public IActionResult ListLesson2(int Ogrenciid)
        {
            //using (var ctx = new OkulDbContext())
            //{
            //    var lst = ctx.OgrenciDersler.ToList();
            //    return View(lst);
            //}
            return View();
        }

        [HttpGet]
        public IActionResult deneme(int Ogrenciid)
        {
            using (var ctx = new OkulDbContext())
            {
                //var lst = ctx.OgrenciDersler.ToList();
                //return View(lst);
                var ogrenciDersleri = ctx.OgrenciDersler.Include(od => od.Ogrenci).Include(od => od.Ders).Where(od => od.OgrenciId == Ogrenciid).ToList();

                return View(ogrenciDersleri);

            }


        }

    }
}
