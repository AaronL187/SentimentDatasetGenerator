using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace SentimentMVCPresentation.Controllers
{
    public class SentenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveNewSentence(string text)
        {

        }
    }
}
