using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_MoodAnalyzer
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.ToUpper().Contains("SAD"))
                return "Sad Mood";
            else
                return "Happy Mood";
        }
    }

}
