using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class QualityScore
    {
        
        public static Terrorist HighestQualityScore()
        {
            
            Terrorist highest = Hamas.ListOfTerrorists[0];
            foreach (Terrorist terrorist in Hamas.ListOfTerrorists)
            {
                if (terrorist.GetScore() > highest.GetScore())
                {
                    highest = terrorist;
                }
              
            }
            return highest;
        }

        public static Terrorist HighestRanked()
        {
            Terrorist highestRank = Hamas.ListOfTerrorists[0];
            foreach (Terrorist terrorist in Hamas.ListOfTerrorists)
            {
                if (terrorist.Rank > highestRank.Rank)
                {
                    highestRank = terrorist;
                }

            }
            return highestRank;

        }
    }
}
