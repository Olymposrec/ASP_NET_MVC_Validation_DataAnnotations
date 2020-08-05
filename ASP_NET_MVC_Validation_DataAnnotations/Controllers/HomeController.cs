using ASP_NET_MVC_Validation_DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Validation_DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Users());
        }
        [HttpPost]
        public ActionResult Index(Users model)
        {
            //ModelState.IsValid
            if (model.kullaniciadi == "melihakkose")
            {
                //ModelState.AddModelError("KullaniciAdi(key)", "Bu kullanıcı adı kullanılıyor.") Validation Summary' de çıkmaz
                ModelState.AddModelError("", "Bu kullanıcı adı kullanılıyor."); /*Validation Summary' de çıkar*/
            }
            return View(model);
        }
    }
}