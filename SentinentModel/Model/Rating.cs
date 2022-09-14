using System;
using SentimentModel.Interface;
using System.Collections.Generic;
using System.Text;

namespace SentimentModel.Model
{
    public class Rating : IOID
    {
        public long OID { get; set; }
        public long SentenceOID { get; set; }
        public long SentimentUserOID { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsPositive { get; set; }

        public virtual SentimentUser SentimentUser { get; set; }
        public virtual Sentence Sentences { get; set; }

    }
}
