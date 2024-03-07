using System;

namespace ChanceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine("Now write a character: ");
            string chr = Console.ReadLine();
            
            foreach chr in str:
            {
                str -= chr;
            }

            Console.WriteLine("Modified Sentence:");
            Console.Write(str);
        }
    }
}
