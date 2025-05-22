using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class Terrorist
    {
        public string Name;
        public int Rank;
        public string LifeStatus;
        public Dictionary<string,int> Weapons;

        
        public Terrorist(string name,int rank, string lifeStatus,Dictionary<string, int> wepons)
        {
            this.Name = name;
            this.Rank = rank;
            this.LifeStatus = lifeStatus;
            this.Weapons = wepons;
        }
       




    }
} 
