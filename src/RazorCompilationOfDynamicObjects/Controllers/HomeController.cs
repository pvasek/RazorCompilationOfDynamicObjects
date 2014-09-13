using System.Linq;
using System.Web.Mvc;
using RazorCompilationOfDynamicObjects.Helpers;

namespace RazorCompilationOfDynamicObjects.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logs = Request.GetRequestStopwatchLogs();
            return View(logs.Where(i => i.Path != "/").ToList());
        }

        
        public ActionResult With_100_dynamic_object_calls()
        {
            return View(new DynamicResource());
        }

        public ActionResult With_100_normal_method_calls()
        {
            return View(new DynamicResource());
        }
    }
}