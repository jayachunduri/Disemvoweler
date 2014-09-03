using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling Disemvoweler function
            Disemvoweler("Two drums and a cymbal fall off a cliff");
        }

        static void Disemvoweler(string input)
        {
            List<string> output = new List<string>();
            List<string> vowels = new List<string>();
            string inputLower = input.ToLower();

            for (int i = 0; i < inputLower.Length; i++)
            {
                //checking if the current letter is a vowel, if so adding to vowels list of strings
                if("aeiou".Contains(inputLower[i]))
                {
                    vowels.Add(inputLower[i].ToString());
                }
                //checking if the current char is a space, if so continue to next value of i. Means not adding to any list.
                else if(" ".Contains(inputLower[i]))
                {
                    continue;
                }
                    //if it's not vowel and not a space, then add it to output list of strings.
                else
                {
                    output.Add(inputLower[i].ToString());
                }
            }

            //printing the output
            foreach (var item in output)
                Console.Write(item.ToUpper());

            Console.WriteLine("\n\nRemoved vowels");

            foreach (var item in vowels)
                Console.Write(item.ToUpper());

            Console.WriteLine("\n");
        }
    }
}
