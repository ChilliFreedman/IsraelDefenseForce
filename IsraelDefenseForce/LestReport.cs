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
            
            foreach (TerroristReport terroristrep in IntelligenceUnit.ListReports)
            {
                if (terroristrep.TerroristInformation == terroristtokell)
                {
                    if (lestrepurt == null)
                    {
                        lestrepurt = terroristrep;
                    }
                    else
                    {
                        if (terroristrep.TimeStamp > lestrepurt.TimeStamp)
                        {
                            lestrepurt = terroristrep;
                        }
                    }
                }
            }
            return lestrepurt;
        }
    }
}
