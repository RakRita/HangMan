using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    public class WordGuess
    {
        public void GuessWord()
        {
            Random random = new Random((int)DateTime.Now.Ticks);


            string[] wordBank = new string[10] { "red", "green", "blue", "violet", "range", "black", "white", "forest", "purpur", "grekland" };
            string secretWord = wordBank[random.Next(0, wordBank.Length)];

            char[] secret = new char[secretWord.Length];
            int count = 10;




            do
            {

               
                Console.WriteLine(secretWord);
                Console.WriteLine("Gissa hela ordet");
                Console.WriteLine("Du har:" + count + " gissningar kvar");


                for (int i = 0; i < secret.Length; i++)
                {
                    secret[i] = '_';
                }
                for (int i = 0; i < secret.Length; i++)
                {
                    Console.Write(secret[i] + " ");
                }
                Console.WriteLine();



                string wholeWord = Console.ReadLine();
                count--;

                if (secretWord == wholeWord)
                {
                    Console.WriteLine("Du gissade rätt,\nDet hemliga ordet var " + wholeWord +"!");
                    break;
                }
                else
                {
                    Console.WriteLine("Inte rätt gissat");
                }
            } while (count > 0);
            if (count == 0)
                Console.WriteLine("Du har gissat fel 10 gånger och spelet är slut");

            Console.ReadLine();
        }
    }
}