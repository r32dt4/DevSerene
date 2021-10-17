using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace DevSerene.Default.Pages
{

    [PageAuthorize(typeof(CalendarRow))]
    public class CalendarController : Controller
    {
        [Route("Default/Calendar")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Calendar/CalendarIndex.cshtml");
        }
    }
}