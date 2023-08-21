using Microsoft.AspNetCore.Mvc;

namespace GeleceginYazarlarıAspnetcoreMVC101.WEB.Controllers
{
    public class Product2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
    public class MvcYapisiController : Controller
    {
        public IActionResult ViewBagTasima()
        {
            ViewBag.title1 = "Bu sayfa ViewBag ile taşınmıştır."; /*ViewBag*/
            ViewBag.descriptions = "Bu komut sadece kendi action'ın view'inde çalışır."; /*ViewBag*/
            ViewBag.name = "Uğur"; /*ViewBag*/
            ViewBag.person = new { Id = 1, isim = "Ali cabbar", yas = 25 }; /*ViewBag*/
            return View();
        }
        public IActionResult ViewDataTasima()
        {
            ViewData["title2"] = "Bu sayfa ViewData ile taşınmıştır."; /*ViewData*/
            ViewData["descriptions"] = "Bu komut sadece kendi action'ın view'inde çalışır."; /*ViewData*/
            ViewData["name"] = "Uğur"; /*ViewData*/
            ViewData["surname"] = "Gündüz"; /*ViewData*/
            ViewData["age"] = 24; /*ViewData*/
            ViewData["namesdata"] = new List<string>() { "Ahmet", "Mehmet", "Hasan" };/*ViewData*/
            return View();
        }
        public IActionResult TempDataTasima()
        {
            TempData["Transport"] = "TempData ile farklı action dosyasına aktarılmıştır."; /*TempData*/
            return View();
        }
        public IActionResult TempDataList()
        {
            return View();
        }
        public IActionResult ViewModelTasima()
        {
            /* product list ViewModel */
            var ProductList = new List<Product2>()
            {
                new(){ Id = 1, Name = "Uğur",  SurName = "GÜNDÜZ",  Age = 24},
                new(){ Id = 2, Name = "Mert",  SurName = "DEMİRCİ", Age = 24},
                new(){ Id = 3, Name = "Buğra", SurName = "CAYDAM",  Age = 24}

            };
            return View(ProductList);
        }

        public IActionResult RedirectToActionBaglanti()
        {
            return RedirectToAction("ViewModelTasima", "MvcYapisi");
        }

        public IActionResult index()
        {
            return View();
        }


        /* Conroller  action method çeşitleri */
        public IActionResult ContentResult()
        {
            return Content("merhaba");
        }
        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 100 });
        }
        public IActionResult EmptyResult() { return new EmptyResult(); }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }
        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }
    }
}
