using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class IntelligenceUnit
    {
        public static List<TerroristReport> ListReports;
        //פונקציה שמחזירה את המחבל עם הכי הרבה דיווחים
        public static Terrorist GetTheterWithMostReports()
        {
            Dictionary<Terrorist,int> counts = new Dictionary<Terrorist,int>();

            
            foreach (TerroristReport report in ListReports)
            {
                if (!counts.ContainsKey(report.TerroristInformition))
                {
                    counts[report.TerroristInformition] = 1;
                }
                else
                {
                    counts[report.TerroristInformition]++;
                }
            }
            Terrorist max = counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return max;

            

        }
       
    }
}
