using System;
using System.Text;
using static System.Console;
using System.Linq;

namespace HangMan
{


    public class Reserv
    {

        public void PlayGame()
        {

            Random random = new Random((int)DateTime.Now.Ticks);


            string[] wordBank = new string[10] { "red", "green", "blue", "violet", "range", "black", "white", "forest", "purpur", "grekland" };
            string secretWord = wordBank[random.Next(0, wordBank.Length)];
            secretWord.ToCharArray();
            char[] secret = new char[secretWord.Length];
            StringBuilder sb = new StringBuilder();
            char[] guessedLetters = new char[10];

            int count = 0;

            Console.WriteLine("välkommen till HangMan");
            Console.WriteLine(secretWord);
            Console.WriteLine();

            for (int i = 0; i < secret.Length; i++)
            {
                secret[i] = '_';
            }
            for (int i = 0; i < secret.Length; i++)
            {
                Console.Write(secret[i] + " ");
            }
            Console.WriteLine();



            do
            {

                Console.WriteLine("gissa en bokstav");

                char input = (Console.ReadLine().ToCharArray()[0]);
                if (!secretWord.Contains(input))
                {

                    sb.Append(input);
                    WriteLine(sb.ToString() + "Dessa bokstäver finns inte i ordet ");
                }

                for (int i = 0; i < secretWord.Length; i++)
                {


                    if (secretWord[i] == input)
                    {

                        secret[i] = input;


                        for (int x = 0; x < secret.Length; x++)
                        {
                            Console.Write(secret[x] + " ");

                        }
                    }



                }
                count++;

            }
            while (count < 10);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}

