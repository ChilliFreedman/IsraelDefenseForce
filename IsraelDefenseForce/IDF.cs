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
        public static void getlistofunitswithstrikleft()
        {
            foreach (StrikeUnit namestrik in IDF.ListOfStrikUnits)
            {
                if (namestrik.StrikLeft > 0)
                {
                    Console.WriteLine($"{namestrik.UnicName}  ,{namestrik.StrikLeft}");
                }

                
            }
            

        }

        



}
}
