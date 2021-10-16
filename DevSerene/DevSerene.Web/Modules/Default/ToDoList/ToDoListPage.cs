using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace DevSerene.Default.Pages
{

    [PageAuthorize(typeof(ToDoListRow))]
    public class ToDoListController : Controller
    {
        [Route("Default/ToDoList")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/ToDoList/ToDoListIndex.cshtml");
        }
    }
}