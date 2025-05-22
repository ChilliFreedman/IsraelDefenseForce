using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelDefenseForce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDF.CurrentCommander = "eyal";
            Hamas.CurrentCommander = "sinwar";
            Console.WriteLine(IDF.CurrentCommander);
            Console.WriteLine(IDF.GetDateOfEstablishment());
            Console.WriteLine(Hamas.CurrentCommander);
            Console.WriteLine(Hamas.GetDateOfEstablishment());
            List<Dictionary<string, int>> listi = new List<Dictionary<string, int>>() ;

            



            Dictionary<string,int> dic = new Dictionary<string, int>() { { "aa", 2 }, { "hh", 2 } };
            Terrorist muhamad = new Terrorist("muhamad", 4, "alive",dic);
            Terrorist ahmed = new Terrorist("ahmed", 3, "alive", dic);
            Terrorist sinwar = new Terrorist("ahmed", 2, "alive", dic);
            Terrorist abu = new Terrorist("ahmed", 5, "ded", dic);
            Terrorist salim = new Terrorist("ahmed", 1, "alive", dic);
            Hamas.ListOfTerrorist = new List<Terrorist>() { muhamad,ahmed};
            TerroristReport report1 = new TerroristReport(muhamad,"home","12/09/12");
            TerroristReport report2 = new TerroristReport(muhamad, "home", "12/09/12");
            TerroristReport report3 = new TerroristReport(muhamad, "home", "12/09/12");
            TerroristReport report4 = new TerroristReport(muhamad, "home", "12/09/12");
            TerroristReport report5 = new TerroristReport(muhamad, "home", "12/09/12");
            F16FighterJet a = new F16FighterJet();
            Hermes460Drone b = new Hermes460Drone();
            M109Artillery c = new M109Artillery();
            
            Console.WriteLine($"name strik: {a.UnicName}. strik left: {a.StrikLeft}:");
            Console.WriteLine($"name strik: {b.UnicName}. strik left: {b.StrikLeft}:");
            Console.WriteLine($"name strik: {c.UnicName}. strik left: {c.StrikLeft}:");

            Console.WriteLine(report5.TerroristInformition.Name);

            //IDF.GetDateOfEstablishment();
        }
    }
}
