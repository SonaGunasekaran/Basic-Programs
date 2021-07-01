using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class VowelOrConsonant
    {

        public static void CheckVowelOrConsonant()
        {
            //Get input from user
            Console.WriteLine("Enter the character");
            string ch = Console.ReadLine();
            // check whether the given charcter 
            // vowel Or Consonant 
            if (ch == "a" || ch == "e" || ch == "i" || ch == "o" || ch == "u" || ch == "A" || ch == "E" || ch == "I" || ch == "O" || ch == "U")
            {
                Console.WriteLine(ch + " is a vowel");
            }
            else
            {
                Console.WriteLine(ch + " is a consonant");
            }

        }
    }
}

