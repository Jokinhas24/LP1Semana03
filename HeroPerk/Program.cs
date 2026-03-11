using System;
using System.Text.Json.Serialization;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("!No perks at all!");
            }
            Perks playerPerks = 0;

            foreach (char perkChar in args[0])
            {
                switch (perkChar)
                {
                    case 'w':
                        playerPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }
            if (playerPerks == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else
            {
            Console.WriteLine(playerPerks);
            }

            if ((playerPerks & Perks.Stealth) != 0 &&
                (playerPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("!Silent jumper!");
            }

            if (playerPerks != Perks.AutoHeal)
            {
                 Console.WriteLine("!Not gonna make it");
            }
        }
    }
}
