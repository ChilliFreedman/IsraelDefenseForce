using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class Attack
    {
        public static void attack(Terrorist terrorist,int num)
        {
            TerroristReport lestreport = LestReport.getLestReourt(terrorist);
            foreach (StrikeUnit strike in IDF.ListOfStrikUnits)
            {

                if (strike.StrikLeft >= num && strike.TypeOfTarget == lestreport.LastKnownLocation)
                {
                    
                    Console.WriteLine($"tame of atack: {DateTime.Now}");
                    DisplayingTheTerrorist_sDetails.DisplayingTerrorist(terrorist);
                    //Console.WriteLine($"{lestreport.TimeStamp}");
                    Console.WriteLine($"lest intelgens report of {terrorist.Name}: locition: {lestreport.LastKnownLocation}, timstamp:{lestreport.TimeStamp} ");
                    
                    Console.WriteLine($"usd {strike.UnicName} with {num} bombs, and {strike.StrikLeft - num} are left aftur the atack");
                    strike.StrikLeft -= num;
                    terrorist.IsAlive = false;

                }
            }

        }
    }
}
