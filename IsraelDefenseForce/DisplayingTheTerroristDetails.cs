using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class  DisplayingTheTerroristDetails
    {
        public static void DisplayingTerrorist(Terrorist terrorist)
        {
            Console.WriteLine($"terrorist {terrorist.Name}");
            Console.WriteLine($"rank: {terrorist.Rank}");
            Console.WriteLine($"score: {terrorist.GetScore()}");
            string writeweapons = "";
            foreach (string a in terrorist.Weapons.Keys)
            {
                writeweapons += $"{terrorist.Weapons[a]} {a} ";
            }
            Console.WriteLine($"weapons: {writeweapons}");



            

                    
                
                
            }
    }
}
