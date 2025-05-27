using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static  class Hamas
    {
        private static string DateOfEstablishment = "1987";

        public static string CurrentCommander = "Mohammed Sinwar";

        public static List<Terrorist> ListOfTerrorists = new List<Terrorist>() { };

        public static string GetDateOfEstablishment()
        {
            return DateOfEstablishment;
        }


    }
}
