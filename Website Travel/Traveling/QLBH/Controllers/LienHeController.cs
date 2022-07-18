using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using QLBH.Models;
using QLBH.Common;
using Model.EF;

namespace QLBH.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe

        public ActionResult Index()
        {
            var dao = new SlideDao();
            var result = dao.GetList();
            return View(result);
        }
        public ActionResult Create(LienHe lienHe)
        {

            MyDB db = new MyDB();

            LienHe LH = new LienHe();
            LH.customerName = lienHe.customerName;
            LH.customerEmail = lienHe.customerEmail;
            LH.contactSubject = lienHe.contactSubject;
            LH.contactMessage = lienHe.contactMessage;

            return View();
        }





    }
}