using System;
using System.Text;
using static System.Console;
using System.Linq;

namespace HangMan
{


    public class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {


                LettersGuess lg = new LettersGuess();
                lg.Play();
            }
        }
    }


}