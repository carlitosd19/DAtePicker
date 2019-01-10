using DAtePicker.Models;
using System.Web.Mvc;

namespace DAtePicker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person p = new Person();
          
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}