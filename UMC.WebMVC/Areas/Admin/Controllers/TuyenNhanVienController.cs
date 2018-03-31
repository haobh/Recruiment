using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UMC.WebMVC.Areas.Admin.Controllers
{
    public class TuyenNhanVienController : Controller
    {
        // GET: Admin/TuyenNhanVien
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}