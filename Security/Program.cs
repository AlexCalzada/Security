using System;

namespace Security
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingresa una palabra");
            string MyWord = Console.ReadLine();
            Console.WriteLine("-------------------");
            var (Message, ReversedWord) = Reverse(MyWord.ToLower());
            Console.WriteLine("Antes: "+ MyWord + "\nDespues: " + ReversedWord);
            Console.WriteLine(Message);
            Console.WriteLine("-------------------");
            Console.WriteLine("¿Cual es el separador a utilizar?");
            string MyChar = Console.ReadLine();
            string separatedWord = Separate(ReversedWord, MyChar);
            Console.WriteLine("Con separacion: " + separatedWord);
            Console.WriteLine("-------------------");
            Console.WriteLine("Volver a reversear");
            string MyWord2 = Reverse(RemoveSeparator(ReversedWord, char.Parse(MyChar))).ReversedWord;
            Console.WriteLine(MyWord2);
            Console.ReadKey();
        }

        static (string Message, string ReversedWord) Reverse(string Word)
        {
            string ReversedWord = string.Empty;
            for (int i = Word.Length - 1; i < Word.Length; i--)
            {
                if (i == -1) break;
                ReversedWord += Word[i];
            }
            string Message = (ReversedWord == Word) ? "[Si] es palindromo" : "[No] es palindromo";
            return (Message, ReversedWord);
        }

        static string Separate(string ReversedWord, string Character)
        {
            string SeparatedWord = string.Empty;
            for (int i = 0; i < ReversedWord.Length; i++)
            {
                SeparatedWord += ReversedWord[i] + Character;
                if ((i + 1) == ReversedWord.Length)
                {
                    SeparatedWord = SeparatedWord.Remove((i * 2) + 1);
                }
            }
            return SeparatedWord;
        }

        static string RemoveSeparator(string Word, char Separator)
        {
            string newWord = Word.Split(Separator)[0];
            return newWord;
        }
    }
}
