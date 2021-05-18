using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser1;
using System;

namespace UnitTestProject1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser1.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
            
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser1.MoodAnalyser", "MoodAna", "SAD");
            expected.Equals(obj);
        }



        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.analyseMood();
          

        }
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodEmpty_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser("");
            string result = obj.analyseMood();
           

        }


    }

}
