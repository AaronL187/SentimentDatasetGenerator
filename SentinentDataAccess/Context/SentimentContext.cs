using Microsoft.EntityFrameworkCore;
using SentimentModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentimentDataAccess.Context
{
    public class SentimentContext : DbContext
    {
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<SentimentUser> SentimentUsers { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override
    }
}
