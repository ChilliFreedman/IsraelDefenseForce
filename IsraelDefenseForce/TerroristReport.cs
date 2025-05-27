using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class TerroristReport
    {
        public Terrorist TerroristInformation;
        public string LastKnownLocation;
        public DateTime TimeStamp;

        public TerroristReport(Terrorist terroristInformation, string lastKnownLocation, DateTime timeStamp)
        {
            this.TerroristInformation = terroristInformation;
            this.LastKnownLocation = lastKnownLocation;
            this.TimeStamp = timeStamp;
        }
    }
}
