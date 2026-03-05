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

            if (system == SystemType.BankDatabase)
            {
                foreach (HackTool hk in hacks)
                    if ((hk == HackTool.ZeroDay) && (hk == HackTool.Backdoor))
                        {
                            Console.WriteLine("System Hacked");
                        }
                    else if ((hk == HackTool.QuantumExploit) && (hk == HackTool.AIOverride))
                    {
                        Console.WriteLine("System Hacked");
                    }
                    else
                    {
                        Console.WriteLine("System Secured");
                    }
                    
            }

            if (system == SystemType.SmartCityCore)
            {
                foreach (HackTool hk in hacks)
                    if ((hk == HackTool.AIOverride) && (hk == HackTool.Backdoor))
                        {
                            Console.WriteLine("System Hacked");
                        }
                    else if ((hk == HackTool.ZeroDay) && (hk == HackTool.BruteForce))
                    {
                        Console.WriteLine("System Hacked");
                    }
                    else if ((hk == HackTool.QuantumExploit) && (hk == HackTool.Phishing))
                    {
                        Console.WriteLine("System Hacked");
                    }
                    else
                    {
                        Console.WriteLine("System Secured");
                    }
                    
            }
            
        }
    }
}
