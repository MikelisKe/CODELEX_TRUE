internal class Program
{
    private static void Main(string[] args)
    {
        string sentence = "Hey, im looking for Nemo !"; // Creating sentence
        string nemo = "Nemo";
        int index = 0;
        string[] sentenceSplit = sentence.Split(' '); // splitting the sentence into array

        for(int i = 0; i < sentenceSplit.Length; i++)
        {
            if (sentenceSplit[i] == nemo)
            {
                Console.WriteLine($"I found the Nemo on {i+1} ");
            }
        }
    }
}