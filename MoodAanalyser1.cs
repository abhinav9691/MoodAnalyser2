using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser2
{
    public class MoodAanalyser1
    {
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }

        }
    }
}
