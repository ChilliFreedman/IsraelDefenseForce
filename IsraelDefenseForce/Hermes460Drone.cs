using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class Hermes460Drone : StrikeUnit
    {
        

        public Hermes460Drone(string unicName = "Hermes460", int strikLeft = 3, int fuelSupply = 0, string typeOfTarget  = "car", string bombTypes = " personnel or armored vehicles")
            : base(unicName, strikLeft, fuelSupply, typeOfTarget)

        {
            
        }
    }
}
