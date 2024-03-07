using System;

namespace HeroPerks
{
     [Flags]
            public enum Perks
            {
            None = 0,
            WaterBreathing = 1,
            Stealth = 2,
            AutoHeal = 4,
            DoubleJump = 8
            }
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
        {
            Console.WriteLine("Player has no perks");s
            return;
        }
            Perks playerPerks = Perks.None;

            foreach (char perkChar in args[0])
        {
            switch (perkChar)
            {
                case 'w':
                    playerPerks ^= Perks.WaterBreathing;
                    break;
                case 'a':
                    playerPerks ^= Perks.Stealth;
                    break;
                case 's':
                    playerPerks ^= Perks.AutoHeal;
                    break;
                case 'd':
                    playerPerks ^= Perks.DoubleJump;
                    break;
                default:
                    Console.WriteLine("Unknown perk!");
                    return;
            }
        }   
             if (playerPerks == Perks.None)
        {
            Console.WriteLine("No perks at all!");
        }
            else
        {
            Console.WriteLine($"Player has this perks: {playerPerks}");

            if ((playerPerks & Perks.Stealth) != 0 && (playerPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("Silent jumper!");
            }
        }
    }
}
