using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class TerroristReport
    {
        public Terrorist TerroristInformition;
        public string LastKnownLocation;
        public string TimeStamp;

        public TerroristReport(Terrorist terroristInformition, string lastKnownLocation, string timeStamp)
        {
            this.TerroristInformition = terroristInformition;
            this.LastKnownLocation = lastKnownLocation;
            this.TimeStamp = timeStamp;
        }
    }
}
