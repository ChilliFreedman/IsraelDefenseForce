using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class Attack
    {
        public static void ToAttack(Terrorist terrorist,int num)
        {
            TerroristReport latestReport = LatestReport.GetLatestReport(terrorist);
            foreach (StrikeUnit strike in IDF.ListOfStrikeUnits)
            {

                if (strike.StrikesLeft >= num && strike.TypeOfTarget == latestReport.LastKnownLocation)
                {
                    
                    Console.WriteLine($"Time of attack: {DateTime.Now}");
                    DisplayingTheTerroristDetails.DisplayingTerrorist(terrorist);
                    //Console.WriteLine($"{lestreport.TimeStamp}");
                    Console.WriteLine($"Latest inteligence report of {terrorist.Name}: location: {latestReport.LastKnownLocation}, timstamp:{latestReport.TimeStamp} ");
                    
                    Console.WriteLine($"used {strike.UniqueName} with {num} bombs, and {strike.StrikesLeft - num} are left after the attack");
                    strike.StrikesLeft -= num;
                    terrorist.IsAlive = false;

                }
            }

        }
    }
}
