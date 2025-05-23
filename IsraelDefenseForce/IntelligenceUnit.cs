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
        public static string GetTheterWithMostReports(List<TerroristReport> listReports)
        {
            Dictionary<Terrorist,int> counts = new Dictionary<Terrorist,int>();

            
            foreach (TerroristReport report in listReports)
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
            var max = counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return max.Name;

        }
    }
}
