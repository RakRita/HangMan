using System;
using System.Text;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace HangMan
{


    public class LettersGuess
    {
        Random random = new Random((int)DateTime.Now.Ticks);




        public void Play()
        {
            string[] wordBank = new string[10] { "red", "island", "blue", "violet", "range", "black", "white", "forest", "yellow", "grekland" };
            string secretWord = wordBank[random.Next(0, wordBank.Length)];
            secretWord.ToCharArray();
            char[] secret = new char[secretWord.Length];

          
            StringBuilder sb = new StringBuilder();
            string input1;
            int count = 10;

            List<char> corrcetGuesses = new List<char>();
            List<char> inCorrcetGuesses = new List<char>();



            Console.WriteLine("Du har 10 gissningar");
            Console.WriteLine(secretWord);
            Console.WriteLine();


           


            for (int i = 0; i < secret.Length; i++)
            {
                secret[i] = '_';
            }
        /*    for (int i = 0; i < secret.Length; i++)
            {
                Console.WriteLine(secret[i] + " ");
            }*/
            Console.WriteLine();
           

            do
            {

                Console.WriteLine("\nDessa bokstäver finns inte i ordet: " + sb.ToString());
                Console.WriteLine("Gissa en bokstav eller hela ordet");
                for (int x = 0; x < secret.Length; x++)
                {
                    Console.Write(secret[x] + " " );



                }

                Console.WriteLine();
                input1 = Console.ReadLine();
                count--;

                Console.WriteLine("gissningar kvar" + count);



              
                if (input1.Length == 1)
                {


                    char input = char.Parse(input1);




                    if (corrcetGuesses.Contains(input))
                    {
                        Console.WriteLine("Du har redan gissat på: " + input + " och det var en av de rätta bokstäverna");
                        count++;
                        continue;
                    }

                    if (inCorrcetGuesses.Contains(input))
                    {
                        Console.WriteLine("Du har redan gissat på " + input + "och det var fel");
                        count++;
                        continue;
                    }




                    if (!secretWord.Contains(input))
                    {

                        sb.Append(input);
                        // WriteLine( "Dessa bokstäver finns inte i ordet: " + sb.ToString());
                        inCorrcetGuesses.Add(input);

                    }

                    for (int i = 0; i < secretWord.Length; i++)
                    {


                        if (secretWord[i] == input)
                        {
                            corrcetGuesses.Add(input);
                            secret[i] = input;


                            for (int x = 0; x < secret.Length; x++)
                            {
                                Console.Write(secret[x] + " ");



                            }


                        }


                    }
                 if (!secret.Contains('_'))
                    {
                        Console.WriteLine("Du gissade rätt");
                        break;
                    }
                }
                else if (input1.Length >= 1)
                {
                    if (secretWord == input1)
                    {
                        Console.WriteLine("Rärtt");
                        break;
                    }
                    if (secretWord !=input1)
                    {
                        Console.WriteLine("fel ord");
                    }
                }
               



            } while (count > 0);
            if (count == 0)
            {
                Console.WriteLine("Nu har du gissat 10 gånger och spelet avslutas");
            }

            Console.ReadLine();


        }
       
    } }