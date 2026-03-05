using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            Console.Write("Character: ");
            char c = char.Parse(Console.ReadLine());

            char x = char.Parse("x");
            s = s.Replace(c, x);

            Console.Write("Impressed: " + s);
            
            
        }
    }
}
