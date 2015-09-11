using System.Dynamic;

namespace StringService.Test.Common
{
    public static class TestHelper
    {
        public static dynamic Bag { get; private set; }

        static TestHelper()
        {
            Bag = new ExpandoObject();
        }
    }
}