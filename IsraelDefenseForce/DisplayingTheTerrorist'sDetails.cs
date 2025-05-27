using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class  DisplayingTheTerrorist_sDetails
    {
        public static void DisplayingTerrorist(Terrorist terrorist)
        {
            Console.WriteLine($"terrorist {terrorist.Name}");
            Console.WriteLine($"rank: {terrorist.Rank}");
            Console.WriteLine($"scure: {terrorist.getscure()}");
            string ritewepons = "";
            foreach (string a in terrorist.Weapons.Keys)
            {
                ritewepons += $"{terrorist.Weapons[a]} {a} ";
            }
            Console.WriteLine($"wepons: {ritewepons}");



            

                    
                
                
            }
    }
}
