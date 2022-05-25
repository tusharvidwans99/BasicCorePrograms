using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public static void isVowel()
        {
            char ch;
                    
            Console.Write("Enter the Character to check it is Vowel or Consonant: ");
            ch=Convert.ToChar(Console.ReadLine().ToLower());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine($"{ch} is Vowel");
            }
            else
            {
                Console.WriteLine($"{ch} is Consonant");
            }




        }
    }
}
