using SuZhou.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuZhou.Controllers
{
    public class BaseController : Controller
    {
        protected int MenuId = 0;
        protected BaseController()
        {
            MenuId = (GetType().GetCustomAttributes(true)[0] as MenuAttribute).Id;
        }
        public PartialViewResult LeftMenu()
        {
            //这里获取数据库的菜单对象 
            return PartialView("LeftMenu",MenuId);
        }
    }
}