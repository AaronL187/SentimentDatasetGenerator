using SentimentDataAccess.Context;
using SentimentDataAccess.Interfaces;
using SentimentModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentimentDataAccess.Repositories
{
    public class SentenceRepository : BaseRepository<Sentence, SentimentContext>, ISentenceRepository
    {

    }
}
