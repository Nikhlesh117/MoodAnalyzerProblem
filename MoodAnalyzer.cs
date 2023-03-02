using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {

            try
            {
                if (this.message.Contains("Sad"))

                    return "Sad";
                else

                    return "Happy";
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
