using System;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enum.TryParse(Console.ReadLine(), out SystemType system);

            string[] hacks = new string(Console.ReadLine());

            //hacks.Split(" ");
            
            foreach (string h in hacks)
            {
                Console.WriteLine(h);
                Enum.TryParse(h, out HackTool hack);
            }


            if (system == SystemType.CorporateServer)
            {
                foreach (HackTool hk in hacks)
                    if ((hk == HackTool.Phishing) || (hk == HackTool.Backdoor))
                        {
                            if ((hk == HackTool.BruteForce) || (hk == HackTool.ZeroDay))
                            {
                             Console.WriteLine("System Hacked");
                            }
                        }
                    else
                    {
                        Console.WriteLine("System Secured");
                    }
                    
            }
            
        }
    }
}
