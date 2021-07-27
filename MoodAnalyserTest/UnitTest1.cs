using Day20_MoodAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserTest
{
    [TestClass]
    public class Tests
    {
        public void SadMoodTest()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad mood");
            string expected = "Sad Mood";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HappyMoodTest()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in any mood");
            string expected = "Happy Mood";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
