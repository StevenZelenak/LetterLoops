using System;
using System.Linq;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------

            //Letter Loops
            //------------------------------------------------------------

            //The random words array to check
            var randomWords = new string[] { "abcd", "RqaEzty", "cwAt" };
            //The count that keeps track of how many letters
            int count = 1;
            //Bool the keeptrack of uppercase characters
            bool isUppercase = false;

            foreach (string word in randomWords)
            {
                for (int counter = 0; counter <= word.Length - 1; counter++)
                {
                    for (int countDown = count; countDown > 0; countDown--)
                    {
                        
                        if (isUppercase && countDown == 1 && counter == (word.Length -1))
                        {
                            Console.Write(word.ToLower()[counter]);
                        }
                        else if (isUppercase && countDown == 1)
                        {
                            
                            Console.Write(word.ToLower()[counter]);
                            Console.Write("-");
                        }
                        else if(!isUppercase && countDown == 1)
                        {
                            Console.Write(word.ToUpper()[counter]);
                            Console.Write("-");
                            isUppercase = true;
                        }
                        else if (!isUppercase)
                        {
                            //uppercase the letter and say uppercase is true
                            Console.Write(word.ToUpper()[counter]);
                            isUppercase = true;
                        }
                        else
                        {
                            //everything in here should be lowercase
                            Console.Write(word.ToLower()[counter]);
                        }
                        
                    }
                    //turn uppercase to false so to reset it for the other letters
                    isUppercase = false;
                    count++;
                }
                Console.WriteLine("\n");
                count = 1;
                //Console.WriteLine("\n");
            }
        }
    }
}
