using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentBusinessLogic.Managers;
using SentimentCore.DependencyInjection;
using System.Collections.Generic;
using System.IO;
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
                return Json(new { IsSuccess = false }); //kicsi/nagy i??
            }
            return Json(new { IsSuccess = true });
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    var sentences = new List<string>();
                    string _FileName = Path.GetFileName(file.FileName);
                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        while (reader.Peek() >=0)
                            sentences.Add(reader.ReadLine());
                    }
                    SentenceManager().SaveNewSentences(sentences);

                }
                //ViewBag.Message = "File Uploaded Successfully!!";
                //return View();
            }
            catch
            {
                //ViewBag.Message = "File upload failed!!";
                //return View();

            }

            return RedirectToAction("Index");
        }
    }
}
