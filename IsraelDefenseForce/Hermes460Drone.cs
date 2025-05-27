using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class Hermes460Drone : StrikeUnit
    {
        

        public Hermes460Drone(string uniqueName = "Hermes460", int strikesLeft = 3, int fuelSupply = 0, string typeOfTarget  = "people" + "car", string bombTypes = " personnel or armored vehicles")
            : base(uniqueName, strikesLeft, fuelSupply, typeOfTarget)

        {
            
        }
    }
}
