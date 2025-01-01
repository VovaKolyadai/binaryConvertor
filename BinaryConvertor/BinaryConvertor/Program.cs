using System.Text.RegularExpressions;

namespace BinaryConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var conversion = BinaryConvertor.Convert("100000");
            var pattern = "(0|2|4|6|8)$";
            Regex reg = new Regex(pattern);
            var result = reg.Match(conversion.ToString());
            Console.WriteLine(result.Success);
        }
    }
}
