using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDATXE.Controllers
{
    public class TracuuController : Controller
    {
        // GET: Tracuu
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KetQuaTraCuu(string maVe)
        {
            var thongTinVe = TicketController(maVe); // Thay thế bằng cách truy vấn thực tế của bạn
            return View(thongTinVe);
        }

    }
}