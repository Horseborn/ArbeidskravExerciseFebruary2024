using System.Text;

namespace ArbeidskravExercise;

class Program
{
    static void Main(string[] args)
    {
        string vowels = "aeiouAEIOU";
        string words = "gbmnkkkl";
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
        Console.WriteLine(translatedString);



    }
}