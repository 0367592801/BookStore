using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class DanhMucSachController : Controller
    {
        // GET: Admin/DanhMucSach
        public ActionResult Index()
        {
            return View();
        }
    }
}