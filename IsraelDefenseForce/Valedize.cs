using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal static class Valedize
    {
        public static bool IsValid(string name, string code)
        {
            if (IDF.ListSolderNames.Contains(name) && IDF.GetCode() == code)
            {
                return true;
            }
            return false;
        }

        
    }
}
