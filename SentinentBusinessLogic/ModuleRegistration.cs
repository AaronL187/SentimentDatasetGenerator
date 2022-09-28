using SentimentBusinessLogic.Managers;
using SentimentDataAccess.Interfaces;
using SentimentDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace SentimentBusinessLogic
{
    public class ModuleRegistration
    {
        private readonly UnityContainer _unityContainer;
        public ModuleRegistration(UnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }
        public void Register()
        {
            _unityContainer.RegisterType<RatingManager>();
            _unityContainer.RegisterType<SentenceManager>();

        }
    }
}
