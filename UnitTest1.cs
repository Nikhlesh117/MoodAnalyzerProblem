using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    namespace MoodAnalyzerMSTest
    {
        [TestClass]
        public class UnitTest1
        {
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            [TestMethod]
            public void GivenSadMood()
            {
                //Arrange
                string expected = "SAD";

                //Act
                string actual = moodAnalyzer.AnalyzeMood("I am in Sad Mood");

                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenOtherMoodHAPPY()
            {
                //Arrange
                string expected = "HAPPY";

                //Act
                string actual = moodAnalyzer.AnalyzeMood("I am in Other Mood");

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}