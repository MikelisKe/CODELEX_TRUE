internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ReverseTheCase("ZirgA AsTiTe"));
        
        static string ReverseTheCase(string input)
        {
            string result = "";
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == char.ToUpper(chars[i]))
                {
                    chars[i] =  char.ToLower(chars[i]);
                }
                else
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                result = result + chars[i];
            }

            return result;
        }
    }
}