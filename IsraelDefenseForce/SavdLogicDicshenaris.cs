using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static  class SavdLogicDicshenaris
    {
        public static Dictionary<string,Terrorist> DicsheneryNameTerrorist()
        {
            Dictionary<string, Terrorist> DictNameTerr = new Dictionary<string, Terrorist>();
            foreach(Terrorist terrorist in Hamas.ListOfTerrorist)
            {
                DictNameTerr[terrorist.Name] = terrorist;
            }
            return DictNameTerr;
        }
    }
}
