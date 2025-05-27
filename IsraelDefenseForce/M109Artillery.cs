using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class M109Artillery : StrikeUnit
    {
        public string BombTypes;

        public M109Artillery(string uniqueName = "M109", int strikesLeft = 40, int fuelSupply = 20, string typeOfTarget = "open areas", string bombTypes = "explosive shells")
                : base(uniqueName, strikesLeft, fuelSupply, typeOfTarget)
        {
            this.BombTypes = bombTypes;
        }
    }
}