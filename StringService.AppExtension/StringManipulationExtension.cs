using StringService.App;
using System.Linq;

namespace StringService.AppExtension
{
    public class StringManipulationExtension : StringManipulation
    {
        public static object LowerCase(string v)
        {
            return v.ToLower();
        }

        public static object Reverse(string v)
        {
            return new string(Enumerable.Range(1, v.Length).Select(i => v[v.Length - i]).ToArray());
        }
    }
}
