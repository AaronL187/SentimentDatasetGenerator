using System;
using System.Collections.Generic;
using System.Text;

namespace SentimentDataAccess.Configuration
{
    public static class SentimentDbConfiguration
    {
        public static string GetConnectionString()
        {
            return @"Data Source=DESKTOP-EJTHMUV\;Initial Catalog=SentimentDb;Integrated Security=True;";
        }
    }
}
