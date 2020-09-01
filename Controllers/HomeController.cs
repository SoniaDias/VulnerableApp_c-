using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Contact(string param)
        {
            var jsSerial = new JavaScriptSerializer();
            // JS CODE
            ViewBag.Param1 = (!string.IsNullOrEmpty(param)) ? param : @"""; alert(1);//";
            ViewBag.Param2 = (!string.IsNullOrEmpty(param)) ? param : "'; alert(2);//";
            ViewBag.Param3 = (!string.IsNullOrEmpty(param)) ? param : "alert(3)";
            ViewBag.Param4 = (!string.IsNullOrEmpty(param)) ? param : JsonConvert.SerializeObject("alert(4)");
            ViewBag.Param5 = (!string.IsNullOrEmpty(param)) ? param : jsSerial.Serialize("alert(5)");
            ViewBag.Param6 = (!string.IsNullOrEmpty(param)) ? param : HttpUtility.JavaScriptStringEncode("alert(6)");
            ViewBag.Param7 = (!string.IsNullOrEmpty(param)) ? param : "');alert(7)//";
            // HTML CODE
            ViewBag.Param8 = (!string.IsNullOrEmpty(param)) ? param : "<img src='x' onerror='alert(8)'/>";
            ViewBag.Param9 = (!string.IsNullOrEmpty(param)) ? param : "&lt;script&gt;alert(9)&lt;/script&gt;";
            ViewBag.Param10 = (!string.IsNullOrEmpty(param)) ? param : "javascript:alert(10)";
            ViewBag.Param11 = (!string.IsNullOrEmpty(param)) ? param : "alert(11)";
            ViewBag.Param12 = (!string.IsNullOrEmpty(param)) ? param : "alert(12)";

            return View();
        }
    }
}
