using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length < 3)
                {
                    continue;
                }
                else if (s.Length > 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
            ;
        }
    }
}
