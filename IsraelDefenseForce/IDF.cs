using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class IDF 
    {
        private static string DateOfEstablishment = "26/05/1948"; 
        
        public static string CurrentCommander = "Eyal Zamir";

        public static List<StrikeUnit> ListOfStrikUnits;
        public static string GetDateOfEstablishment()
        {
            return DateOfEstablishment;
        }
        public static void GetListOfUnitsWithStrikesLeft()
        {
            foreach (StrikeUnit strike in ListOfStrikUnits)
            {
                if (strike.StrikesLeft > 0)
                {
                    Console.WriteLine($"{strike.UniqueName}  ,{strike.StrikesLeft}");
                }

                
            }
            

        }

        



}
}
