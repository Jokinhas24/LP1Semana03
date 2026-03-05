using System;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enum.TryParse(Console.ReadLine(), out SystemType system);
            Enum.TryParse(Console.ReadLine(), out HackTool hack);

            if (system == SystemType.CorporateServer)
            {
                
            }
            Console.WriteLine("System Hacked");
        }
    }
}
