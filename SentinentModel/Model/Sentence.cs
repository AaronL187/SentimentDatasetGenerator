using System;
using SentimentModel.Interface;
using System.Collections.Generic;
using System.Text;

namespace SentimentModel.Model
{
    public class Sentence
    {
        public long OID { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

    }
}
