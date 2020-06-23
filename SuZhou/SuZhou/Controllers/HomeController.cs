using SuZhou.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuZhou.Controllers
{
    [Menu(1)]//这个是 和数据库做对比  获取不一样的菜单的
    public class HomeController : BaseController
    {
        public HomeController() : base()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}