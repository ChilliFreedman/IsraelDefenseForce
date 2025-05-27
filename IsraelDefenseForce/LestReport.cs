using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class LestReport
    {
        public static TerroristReport getLestReourt(Terrorist terroristtokell)
        {
            TerroristReport lestrepurt = null;
            
            foreach (TerroristReport terrorist in IntelligenceUnit.ListReports)
            {
                if (terrorist.TerroristInformation == terroristtokell)
                {
                    if (lestrepurt == null)
                    {
                        lestrepurt = terrorist;
                    }
                    else
                    {
                        if (terrorist.TimeStamp > lestrepurt.TimeStamp)
                        {
                            lestrepurt = terrorist;
                        }
                    }
                }
            }
            return lestrepurt;
        }
    }
}
