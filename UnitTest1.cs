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
        }
    }
}