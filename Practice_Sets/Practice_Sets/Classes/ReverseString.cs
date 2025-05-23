using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Practice_Sets.Classes
{
    internal static class ReverseString
    {
        public static string Reverse(string input)
        {
            Console.WriteLine($" input string : {input}");
            char[] charArray = input.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                sb.Append(charArray[i]);
            }

            Console.WriteLine($"output = {sb.ToString()}");
            return sb.ToString();
        }
    }
}
