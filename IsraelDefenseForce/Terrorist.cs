﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class Terrorist
    {
        public string Name;
        public int Rank;
        public bool IsAlive;
        public Dictionary<string, int> Weapons;


        public Terrorist(string name, int rank, bool isAlive, Dictionary<string, int> wepons)
        {
            this.Name = name;
            this.Rank = rank;
            this.IsAlive = isAlive;
            this.Weapons = wepons;
        }

        public int getscure()
        {
            
            int numWepon = 0;
            if (Weapons.Keys.Contains("ak47"))
            {
                numWepon += Weapons["ak47"] * 3;
            }
            if (Weapons.Keys.Contains("m16"))
            {
                numWepon += Weapons["m16"] * 3;
            }
            if (Weapons.Keys.Contains("gun"))
            {
                numWepon += Weapons["gun"] * 2;
            }
            if (Weapons.Keys.Contains("knife"))
            {
                numWepon += Weapons["knife"] * 1;
            }
            numWepon *= Rank;
            return numWepon;


        }
        







    }






}

