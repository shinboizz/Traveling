using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace QLBH.Areas.Admin.Controllers
{
    public class HistoryController : BaseController
    {
        // GET: Admin/News
        public ActionResult Index()
        {
            var dao = new OrderDao();
            var result = dao.GetList();
            return View(result);
        }
    }
}