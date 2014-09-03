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
            Disemvoweler("Nickleback is my favourite band. Their songwriting can't be beat!");

            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");

            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
        }

        static void Disemvoweler(string input)
        {
            List<string> output = new List<string>();
            List<string> vowels = new List<string>();
            string inputLower = input.ToLower();

            for (int i = 0; i < inputLower.Length; i++)
            {
                //checking if the current letter is a vowel, if so adding to vowels list of strings
                if ("aeiou".Contains(inputLower[i]))
                {
                    vowels.Add(inputLower[i].ToString());
                }
                //checking if the current char is a space, if so continue to next value of i. Means not adding to any list.
                else if (" ".Contains(inputLower[i]))
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
            Console.WriteLine("Original: " + input);

            Console.WriteLine("Disemvoweled: ");
            foreach (var item in output)
                Console.Write(item);

            Console.WriteLine("\n");
        }
    }
}
