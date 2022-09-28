using SentimentBusinessLogic.ViewModels;
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
        #region lazy loaded objects

        private ISentenceRepository _sentenceRepository;
        private ISentenceRepository SentenceRepository()
        {
            if (_sentenceRepository == null)
            {
                _sentenceRepository = SDI.Resolve<ISentenceRepository>();
            }
            return _sentenceRepository;
        }


        #endregion
        public AddRatingViewModel GetAddRatingModel()
        {
            var sentence = SentenceRepository().GetRandomSentence();
            var ratingViewModel = new AddRatingViewModel()
            {
                SentenceOID = sentence.OID,
                SentenceText = sentence.Text
            };
            ratingViewModel.SentimentUserOID = 1; //todo
            return ratingViewModel;
        }
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
