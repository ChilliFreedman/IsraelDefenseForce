using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class M109Artillery : StrikeUnit
    {
        public new string UnicName = "M109";
        public new int StrikLeft = 40;
        public new int FuelSupply;
        public new string TypeOfTarget = "open areas";
    }
}
