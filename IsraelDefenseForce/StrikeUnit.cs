using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal abstract class StrikeUnit
    {
        public string UnicName;
        public int StrikLeft;
        public int FuelSupply;
        public string TypeOfTarget;

        public StrikeUnit(string unicName, int strikLeft, int fuelSupply, string typeOfTarget)
        {
            this.UnicName = unicName;
            this.StrikLeft = strikLeft;
            this.FuelSupply = fuelSupply;
            this.TypeOfTarget = typeOfTarget;
        }

    }
}
