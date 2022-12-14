using System;
using SentimentModel.Interface;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SentimentModel.Model
{
    [Table("Ratings")]
    public class Rating : IOID
    {
        [Key]
        public long OID { get; set; }
        public long SentenceOID { get; set; }
        public long SentimentUserOID { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsPositive { get; set; }

        [ForeignKey("SentimentUserOID")]
        public virtual SentimentUser SentimentUser { get; set; }
        [ForeignKey("SentenceOID")]
        public virtual Sentence Sentence { get; set; }

    }
}
