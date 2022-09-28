using SentimentCore.DependencyInjection;
using SentimentDataAccess.Interfaces;
using SentimentDataAccess.Repositories;
using SentimentModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentimentBusinessLogic.Managers
{
    public class SentenceManager
    {
        #region lazy
        private ISentenceRepository _sentenceRepository;
        private ISentenceRepository SentenceRepository()
        {
            if (_sentenceRepository == null)
            { _sentenceRepository = SDI.Resolve<ISentenceRepository>()}
            return _sentenceRepository;
        }

        #endregion

        public void SaveNewSentence(string text)
        {
            SentenceRepository().Add(new Sentence() { Text = text, CreatedAt = DateTime.Now });
        }
    }
}
