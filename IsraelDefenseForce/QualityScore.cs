using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class QualityScore
    {
        
        public static Terrorist  voQualityScore()
        {
            
            Terrorist hii = Hamas.ListOfTerrorist[0];
            foreach (Terrorist terrorist in Hamas.ListOfTerrorist)
            {
                if (terrorist.getscure() > hii.getscure())
                {
                    hii = terrorist;
                }
              
            }
            return hii;
        }

        public static Terrorist gethiranke()
        {
            Terrorist hiiranke = Hamas.ListOfTerrorist[0];
            foreach (Terrorist terrorist in Hamas.ListOfTerrorist)
            {
                if (terrorist.Rank > hiiranke.Rank)
                {
                    hiiranke = terrorist;
                }

            }
            return hiiranke;

        }
    }
}
