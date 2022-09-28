using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentBusinessLogic.Managers;
using SentimentCore.DependencyInjection;

namespace SentimentMVCPresentation.Controllers
{
    public class RatingController : Controller
    {
        #region lazy loaded objects

        private RatingManager _ratingManager;
        private RatingManager RatingManager()
        {
            _ratingManager = SDI.Resolve<RatingManager>();
            return _ratingManager;
        }


        #endregion
        // GET: RatingController
        public ActionResult Index()
        {
            var model = RatingManager().GetAddRatingModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult SaveNewRating(long sentenceOid, long sentimentUserOid, bool? rating = null)
        {
            try
            {
                RatingManager().PersistRating(sentimentUserOid, sentenceOid, rating);
            }
            catch (System.Exception)
            {
                return Json(new {isSuccess = false});
            }
            return Json(new { isSuccess = true });
        }

        //// GET: RatingController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: RatingController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: RatingController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RatingController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RatingController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RatingController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RatingController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
