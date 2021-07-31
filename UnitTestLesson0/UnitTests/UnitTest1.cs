using NUnit.Framework;
using CodeToTest0;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(8)] //parameterising the values
        [TestCase(11)]
        [TestCase(12)]
        public void GivenATimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            //Arrange- setting up data for testing
            //var time = 21;
            var expectedGreeting = "Good morning!";
            //Act- initiating 
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}