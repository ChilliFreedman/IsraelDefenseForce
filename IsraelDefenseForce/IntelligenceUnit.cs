using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class IntelligenceUnit
    {
        public static List<TerroristReport> ListReports;
        public static string GetTheTerroristWithMostReports()
        {
            Dictionary<Terrorist,int> counts = new Dictionary<Terrorist,int>();

            
            foreach (TerroristReport report in ListReports)
            {
                if (!counts.ContainsKey(report.TerroristInformation))
                {
                    counts[report.TerroristInformation] = 1;
                }
                else
                {
                    counts[report.TerroristInformation]++;
                }
            }
            var max = counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return max.Name;

        }
    }
}
