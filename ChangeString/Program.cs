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

            str = str.Replace(chr, "X");

            Console.WriteLine("Modified Sentence:");
            Console.Write(str);
        }
    }
}
