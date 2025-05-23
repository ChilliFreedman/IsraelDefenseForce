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

        public M109Artillery(string unicName = "M109", int strikLeft = 40, int fuelSupply = 20, string typeOfTarget = "open areas", string bombTypes = "explosive shells")
                : base(unicName, strikLeft, fuelSupply, typeOfTarget)
        {
            this.BombTypes = bombTypes;
        }
    }
}