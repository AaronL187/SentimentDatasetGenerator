using Microsoft.AspNetCore.Mvc;
using SentimentBusinessLogic.Managers;
using SentimentCore.DependencyInjection;
using System.Web;

namespace SentimentMVCPresentation.Controllers
{
    public class SentenceController : Controller
    {
        #region

        private SentenceManager _sentenceManager;
        private SentenceManager SentenceManager()
        {
            if (_sentenceManager == null)
            { _sentenceManager = SDI.Resolve<SentenceManager>(); }
            return _sentenceManager;
        }


        #endregion
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveNewSentence(string text)
        {
            try
            {
                SentenceManager().SaveNewSentence(text);
            }
            catch (System.Exception)
            {
                return Json
            }
        }
    }
}
