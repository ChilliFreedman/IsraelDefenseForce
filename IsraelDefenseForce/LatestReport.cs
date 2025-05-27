using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class LatestReport
    {
        public static TerroristReport GetLatestReport(Terrorist terroristToKill)
        {
            TerroristReport latestReport = null;
            
            foreach (TerroristReport terrorist in IntelligenceUnit.ListReports)
            {
                if (terrorist.TerroristInformation == terroristToKill)
                {
                    if (latestReport == null)
                    {
                        latestReport = terrorist;
                    }
                    else
                    {
                        if (terrorist.TimeStamp > latestReport.TimeStamp)
                        {
                            latestReport = terrorist;
                        }
                    }
                }
            }
            return latestReport;
        }
    }
}
