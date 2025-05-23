namespace Practice_Sets.Classes
{
    internal static class Pallindrome
    {
        public static void isPallindrome(string input)
        {
            input = input.ToLower();
            Console.WriteLine($"input : {input}");

            // Suppose string is pallindrome initially
            bool flag = true;

            for (int i = 0, j = input.Length - 1; i <= input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine($"{input} is pallindrome");
            else
                Console.WriteLine($"{input} is not pallindrome");
        }
    }
}
