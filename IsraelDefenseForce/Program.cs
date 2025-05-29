using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace IsraelDefenseForce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //יצירת מחבלים כולל הכנסה לליסט של חמאס
            Dictionary<string, int> dicMohammed = new Dictionary<string, int>() { { "gun", 2 }, { "knife", 2 } };
            Terrorist Mohammed = new Terrorist("Mohammed", 3, true, dicMohammed);
            Hamas.ListOfTerrorist.Add(Mohammed);

            Dictionary<string, int> dicAhmed = new Dictionary<string, int>() { { "ak47", 1 }};
            Terrorist Ahmed = new Terrorist("Ahmed", 3, true, dicAhmed);
            Hamas.ListOfTerrorist.Add(Ahmed);

            Dictionary<string, int> dicAli = new Dictionary<string, int>() { { "gun", 3 } };
            Terrorist Ali = new Terrorist("Ali", 4, true, dicAli);
            Hamas.ListOfTerrorist.Add(Ali);

            Dictionary<string, int> dicOmar = new Dictionary<string, int>() { { "m16", 1 } };
            Terrorist Omar = new Terrorist("Omar", 5, true, dicOmar);
            Hamas.ListOfTerrorist.Add(Omar);

            Dictionary<string, int> dicYousef = new Dictionary<string, int>() { { "ak47", 2 }, { "m16", 1 } };
            Terrorist Yousef = new Terrorist("Yousef", 3, true, dicYousef);
            Hamas.ListOfTerrorist.Add(Yousef);
            //יצירת מופעים לכלי תקיפה כולל הכנסה לרשימה של האב 
            F16FighterJet f16 = new F16FighterJet();
            M109Artillery m109 = new M109Artillery();
            Hermes460Drone zic = new Hermes460Drone();
            IDF.ListOfStrikUnits  = new List<StrikeUnit> { f16, m109, zic };

            //Console.WriteLine(IDF.ListOfStrikUnits.Count);
            //Console.WriteLine(Hamas.ListOfTerrorist.Count);
            //Console.WriteLine(Hamas.CurrentCommander);

            //יצירת דיווחים של אמן
            DateTime date1 = new DateTime(2025, 01, 4);
            DateTime date2 = new DateTime(2025, 01, 25);
            DateTime date3 = new DateTime(2025, 02, 10);
            DateTime date4 = new DateTime(2025, 02, 17);
            DateTime date5 = new DateTime(2025, 02, 28);
            DateTime date6 = new DateTime(2025, 03, 6);
            DateTime date7 = new DateTime(2025, 03, 10);
            DateTime date8 = new DateTime(2025, 03, 15);
            DateTime date9 = new DateTime(2025, 04, 14);
            DateTime date10 = new DateTime(2025, 04, 28);
            TerroristReport report1 = new TerroristReport(Mohammed, "home", date1);
            TerroristReport report2 = new TerroristReport(Yousef, "outside",date2 );
            TerroristReport report3 = new TerroristReport(Ali, "car", date2);
            TerroristReport report4 = new TerroristReport(Mohammed, "home", date3);
            TerroristReport report5 = new TerroristReport(Ali, "home", date4);
            TerroristReport report6 = new TerroristReport(Mohammed, "home", date5);
            TerroristReport report7 = new TerroristReport(Ahmed, "car", date6);
            TerroristReport report8 = new TerroristReport(Mohammed, "home", date7);
            TerroristReport report9 = new TerroristReport(Omar, "home", date8);
            TerroristReport report10 = new TerroristReport(Ahmed, "outsaide", date10);
            //הכנסה לרשימה של אמן
            IntelligenceUnit.ListReports = new List<TerroristReport>()
            { report1,report2,report3,report4,report5,report6,report7,report8,report9,report10};

            //קריאה סופית לתפריט
             InteractiveMenu.RunMenue();
            
            
        }
    }
}
