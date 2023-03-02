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
                if (this.message.Contains(" "))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY, "Mood should not be empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL, "Mood should not be null");
            }
            catch (CustomException exception)
            {
                return exception.Message;
            }
        }
    }
}
