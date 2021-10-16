using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace DevSerene.Default.Pages
{

    [PageAuthorize(typeof(AccountingBookRow))]
    public class AccountingBookController : Controller
    {
        [Route("Default/AccountingBook")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/AccountingBook/AccountingBookIndex.cshtml");
        }
    }
}