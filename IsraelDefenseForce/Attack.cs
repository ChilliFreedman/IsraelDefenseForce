using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class Attack
    {
        public static void attack(Terrorist terrorist,int num,string name)
        {
            
            
            if ( num <= 0)
            {
                Console.WriteLine("not a valid number");
                return;
            }
            TerroristReport lestreport = LestReport.getLestReourt(terrorist);
            foreach (StrikeUnit strike in IDF.ListOfStrikUnits)
            {
                if (!terrorist.IsAlive)
                {
                    Console.WriteLine($"{terrorist.Name} is not alive");
                    return;
                }

                if (strike.StrikesLeft <= num || !strike.TypeOfTarget.Contains( lestreport.LastKnownLocation) || (strike.GetType() == typeof(M109Artillery) && num > 3))
                {
                    continue;
                }
                Console.WriteLine($"tame of atack: {DateTime.Now}");
                Console.WriteLine($"name of solder thet attakt: {name}. ");
                DisplayingTheTerrorist_sDetails.DisplayingTerrorist(terrorist);
                //Console.WriteLine($"{lestreport.TimeStamp}");
                Console.WriteLine($"lest intelgens report of {terrorist.Name}: locition: {lestreport.LastKnownLocation}, timstamp:{lestreport.TimeStamp} ");

                Console.WriteLine($"usd {strike.UniqueName} with {num} bombs, and {strike.StrikesLeft - num} are left aftur the atack");
                strike.StrikesLeft -= num;
                terrorist.IsAlive = false;
                return;
                

            }
            Console.WriteLine("did not attak");
            return;

        }
    }
}
