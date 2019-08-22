using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {

           List<string> letterList = new List<string>();
            Console.WriteLine("Please enter a group of letters");
            var inputLetters = Console.ReadLine();

            List<string> singleLetterList = new List<string>();
            for (var i = 0; i < inputLetters.Length; i++)
            {
                singleLetterList.Add(inputLetters[i].ToString());
   
                int numCount = i + 1;
                string singleLetter = inputLetters[i].ToString().ToLower();
                for (var k = 0; k < numCount; k++)
                {
                    Console.Write((k == 0 ? singleLetter.ToUpper() : singleLetter));
                }
                Console.Write("-");
            }
        }
    }
}
