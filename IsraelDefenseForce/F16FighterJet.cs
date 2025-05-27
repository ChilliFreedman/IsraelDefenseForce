using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class F16FighterJet : StrikeUnit
    {
        public string BombTypes;
       

        public F16FighterJet( string uniqueName = "F16", int strikesLeft = 8, int fuelSupply = 0, string typeOfTarget = "home", string bombTypes = " 0.5 ton or 1 ton")
                : base(uniqueName, strikesLeft, fuelSupply, typeOfTarget)

        {
            this.BombTypes = bombTypes;

        }
    }
}