using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoanhThu()
        {
            return View();
        }

        public ActionResult NhanVien()
        {
            return View();
        }
        public ActionResult TacGia()
        {
            return View();

        }
        public ActionResult NguoiDung()
        {
            return View();

        }

        public ActionResult DanhMucSach()
        {
            return View();

        }
        public ActionResult NhaXuatBan()
        {
            return View();

        }
        public ActionResult Sach()
        {
            return View();

        }
        public ActionResult KhuyenMai()
        {
            return View();

        }
        public ActionResult Login()
        {
            return View();

        }
    }
}