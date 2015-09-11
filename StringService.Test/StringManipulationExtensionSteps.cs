using StringService.AppExtension;
using TechTalk.SpecFlow;
using static StringService.Test.Common.TestHelper;

namespace StringService.Test
{
    [Binding]
    public class StringManipulationExtensionSteps
    {
        [When(@"I consume LowerCase service with '(.*)' string")]
        public void WhenIConsumeLowerCaseServiceWithString(string p0)
        {
            var result = StringManipulationExtension.LowerCase(p0);
            Bag.Result = result;
        }

        [When(@"I consume Reverse service with '(.*)' string")]
        public void WhenIConsumeReverseServiceWithString(string p0)
        {
            var result = StringManipulationExtension.Reverse(p0);
            Bag.Result = result;
        }
    }
}
