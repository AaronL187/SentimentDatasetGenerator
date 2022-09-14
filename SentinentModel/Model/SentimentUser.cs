using System;
using SentimentModel.Interface;
using System.Collections.Generic;
using System.Text;

namespace SentimentModel.Model
{
    public class SentimentUser
    {
        public long OID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
