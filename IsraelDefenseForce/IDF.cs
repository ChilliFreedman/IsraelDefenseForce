using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal  class IDF 
    {
        private static string DateOfEstablishment = "26/05/1948"; 
        
        public static string CurrentCommander;

        public static List<StrikeUnit> ListOfStrikUnits;
        public static string GetDateOfEstablishment()
        {
            return DateOfEstablishment;
        }


        
    }
}
