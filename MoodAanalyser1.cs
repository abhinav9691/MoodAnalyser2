using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser2
{
    public class MoodAanalyser1
    {
        public string message;
        public MoodAanalyser1()
        {

        }
        public MoodAanalyser1(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }

        }
    }
}
