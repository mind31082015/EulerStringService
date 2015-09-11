using NUnit.Framework;
using StringService.App;
using TechTalk.SpecFlow;
using static StringService.Test.Common.TestHelper;

namespace StringService.Test
{
    [Binding]
    public class StringManipulationSteps
    {
        [When(@"I consume UpperCase service with '(.*)' string")]
        public void WhenIConsumeUpperCaseServiceWithString(string p0)
        {
            var result = StringManipulation.UpperCase("tEsT");
            Bag.Result = result;
        }
        
        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            var result = Bag.Result.ToString();

            Assert.AreEqual("TEST", result);
        }
    }
}
