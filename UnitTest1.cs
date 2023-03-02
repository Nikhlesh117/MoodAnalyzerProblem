using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    namespace MoodAnalyzerMSTest
    {
        [TestClass]
        public class UnitTest1
        {
            /*
            [TestMethod]
            public void GivenMessageWhenAnalyzeShouldReturnSadMood()
            {
                MoodAnalyzer obj = new MoodAnalyzer("I am in sad mood.");
                String actualResult = obj.AnalyzeMood();
                Assert.AreEqual("sad", actualResult);
            }
            [TestMethod]
            public void GivenAnyMessageWhenAnalyzeShouldReturnHappyMood()
            {
                MoodAnalyzer obj = new MoodAnalyzer("I am in any mood.");
                String actualResult = obj.AnalyzeMood();
                Assert.AreEqual("happy", actualResult);
            }
            [TestMethod]
            public void TestAnalyseMood_ShouldReturnHAPPY1()
            {
                
                string message = null;
                MoodAnalyzer obj = new MoodAnalyzer(message);
                string result = obj.AnalyzeMood();
                Assert.AreEqual(result, "HAPPY?!!");
            }*/

            //Test Case 3.1
            [TestMethod]
            public void GivenNullMoodWhenAnalyseShouldThrowMoodAnalysisException()
            {
                try
                {
                    MoodAnalyzer mood = new MoodAnalyzer("null");
                    string actual = mood.AnalyzeMood();
                }
                catch (CustomException e)
                {
                    //Assert
                    Assert.AreEqual("Mood Analysis Exception", e.Message);
                }
            }
            //Test Case 3.2
            [TestMethod]
            public void GivenEMPTYMoodWhenAnalyseShouldThrowMoodAnalysisException()
            {
                try
                {
                    MoodAnalyzer mood = new MoodAnalyzer("");
                    string actual = mood.AnalyzeMood();
                }
                catch (CustomException e)
                {
                    Assert.AreEqual("Empty Mood", e.Message);
                }
            }
        }
    }
}