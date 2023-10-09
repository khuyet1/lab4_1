using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TimsachController : Controller
    {
        private object db;

        // GET: Timsach
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TraCuu(string Tensach )
            {
            var lst = db.Sach.where(char=> c.sachName == tenKH).ToList();
                return View();
            }
    } 
}