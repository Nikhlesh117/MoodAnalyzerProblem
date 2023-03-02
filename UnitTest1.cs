using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    namespace MoodAnalyzerMSTest
    {
        [TestClass]
        public class UnitTest1
        {
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
            }
        }
    }
}