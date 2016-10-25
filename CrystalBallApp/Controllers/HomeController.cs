using CrystalBallApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalBallApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ShakeBall()
        {
            //create an object of type Crystal Ball
            CrystalBall ball = new CrystalBall();
            string reply = ball.getResponse();
            return Json(reply, JsonRequestBehavior.AllowGet);
        }
    }
}