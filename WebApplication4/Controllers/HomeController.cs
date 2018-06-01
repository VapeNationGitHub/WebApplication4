using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {


        public string Get()
        {


            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";

            /*
            // Создать объект cookie-набора
            HttpCookie cookie = new HttpCookie("My localhost cookie");
            // Установить значения в нем
            cookie["Language"] = "Russian";
            cookie["Country"] = "ru-ru";
            // Добавить куки в ответ
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddYears(1);
            */
        }
        // request - запрос
        // response - ответ

        public ActionResult Index()
        {



           

            /*
            // Создать объект cookie-набора
            HttpCookie cookie = new HttpCookie("My localhost cookie");
            // Установить значения в нем
            cookie["Language"] = "Russian";
            cookie["Country"] = "ru-ru";
            // Добавить куки в ответ
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddYears(1);
            */



            return View();
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string Contact()
        {
            
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
                
            //return View();
        }

    }
}