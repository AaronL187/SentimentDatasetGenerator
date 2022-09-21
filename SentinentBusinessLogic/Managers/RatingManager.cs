using SentimentCore.DependencyInjection;
using SentimentDataAccess.Interfaces;
using SentimentDataAccess.Repositories;
using SentimentModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentimentBusinessLogic.Managers
{
    public class RatingManager
    {
        public void PersistRating(long sentimentUserOid, long sentenceOid, bool? isPositive)
        { // adatbázisba írás
            var rating = new Rating()
            {
                SentenceOID = sentenceOid,
                SentimentUserOID = sentimentUserOid,
                CreatedAt = DateTime.Now,
                IsPositive = isPositive
            };

            //RatingRepository
            var ratingRepository = SDI.Resolve<IRatingRepository>();
            ratingRepository.Add(rating);

        }
    }
}
