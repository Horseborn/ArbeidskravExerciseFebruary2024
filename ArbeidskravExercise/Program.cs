using System.Text;

namespace ArbeidskravExercise;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)       
        {
            Console.WriteLine("Please provide a string .. ");
            return;
        }
        
        
        string vowels = "aeiouAEIOU";
        string words = args[0];
        StringBuilder sBuilder = new StringBuilder();
        
        foreach (var letter in words)
        {
            if (char.IsLetter(letter))
            {


                if (!vowels.Contains(letter) && !Char.IsWhiteSpace(letter))
                {
                    sBuilder.Append(letter);
                    sBuilder.Append("o");
                    sBuilder.Append(letter);
                }
                else
                {
                    sBuilder.Append(letter);
                }
            }
            else
            {
                sBuilder.Append(letter);
            }
        }

        string translatedString = sBuilder.ToString();
        Console.WriteLine($"The sentence you wanted translated: {words}");
        Console.WriteLine($"Translated sentence: {translatedString}");
        Console.Read();



    }
}