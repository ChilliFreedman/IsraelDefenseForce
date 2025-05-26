using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal abstract class StrikeUnit
    {
        public string UniqueName;
        public int StrikesLeft;
        public int FuelSupply;
        public string TypeOfTarget;

        public StrikeUnit(string uniqueName, int strikesLeft, int fuelSupply, string typeOfTarget)
        {
            this.UniqueName = uniqueName;
            this.StrikesLeft = strikesLeft;
            this.FuelSupply = fuelSupply;
            this.TypeOfTarget = typeOfTarget;
        }

    }
}
