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
            //Mohammed,Ahmed,Ali,Omar,Yousef,Amina,Fatima,Noor,Salim,Layla
            //knife,gun,m16,ak47
            //List<string> TerorisNames = new List<string>() { "Mohammed", "Ahmed", "Ali", "Omar", "Yousef", "Amina", "Fatima", "Noor", "Salim", "Layla" };

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

            F16FighterJet f16 = new F16FighterJet();
            M109Artillery m109 = new M109Artillery();
            Hermes460Drone zic = new Hermes460Drone();
            IDF.ListOfStrikUnits  = new List<StrikeUnit> { f16, m109, zic };

            //Console.WriteLine(IDF.ListOfStrikUnits.Count);
            //Console.WriteLine(Hamas.ListOfTerrorist.Count);
            //Console.WriteLine(Hamas.CurrentCommander);

            //יצירת דיווחים של אמן
            TerroristReport report1 = new TerroristReport(Mohammed, "home", DateTime.Now);
            TerroristReport report2 = new TerroristReport(Yousef, "outside", DateTime.Now);
            TerroristReport report3 = new TerroristReport(Ali, "car", DateTime.Now);
            TerroristReport report4 = new TerroristReport(Mohammed, "home", DateTime.Now);
            TerroristReport report5 = new TerroristReport(Ali, "home", DateTime.Now);
            TerroristReport report6 = new TerroristReport(Mohammed, "home", DateTime.Now);
            TerroristReport report7 = new TerroristReport(Ahmed, "car", DateTime.Now);
            TerroristReport report8 = new TerroristReport(Mohammed, "home", DateTime.Now);
            TerroristReport report9 = new TerroristReport(Omar, "home", DateTime.Now);
            TerroristReport report10 = new TerroristReport(Ahmed, "outsaide", DateTime.Now);
            //הכנסה לרשימה של אמן
            IntelligenceUnit.ListReports = new List<TerroristReport>()
            { report1,report2,report3,report4,report5,report6,report7,report8,report9,report10};

            //foreach (TerroristReport report in IntelligenceUnit.ListReports)
            //{
            //    Console.WriteLine(report.TerroristInformition.Name);
            //}


            //קורא לפונקציה שבודקת איזה מחבל יש הכי הרבה פעמים
            //Console.WriteLine( IntelligenceUnit.GetTheterWithMostReports().Name);
            //קורא לפונקציה של
            //הצגת כלי תקיפה זמינים ואת שארית התחמושת שלהם
            //IDF.getlistofunitswithstrikleft();
            //Console.WriteLine(f16.StrikLeft);
            //קבלת הטרוריסט הכי מסוכן
            Terrorist hiest =  QualityScore.voQualityScore();
            //Console.WriteLine(hiest.Name);
            //קבלת הטרוריסט עם הדרגה הכי גבוהה
            Terrorist hiranke = QualityScore.gethiranke();
            //Console.WriteLine(hiranke.Name);

            //קריאה סופית לתקיפה 
            Attack.attack(hiest,2);
            Attack.attack(hiranke, 2);

            //string funn(Terrorist aaaa)
            //{
            //    string ritewepons = "";
            //    foreach (string a in aaaa.Weapons.Keys)
            //    {

            //        ritewepons += $"{aaaa.Weapons[a]} {a} ";
            //    }
            //    return ritewepons;


            //}

            //TerroristReport tokill = null;
            ////TerroristReport tokill = IntelligenceUnit.ListReports[0];
            //foreach(TerroristReport terrorist in IntelligenceUnit.ListReports)
            //{
            //    if (terrorist.TerroristInformition == hiest)
            //    {
            //        if (tokill == null)
            //        {
            //            tokill = terrorist;
            //        }
            //        else
            //        {
            //            if (terrorist.TimeStamp > tokill.TimeStamp)
            //            {
            //                tokill = terrorist;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(tokill.TerroristInformition.Name +  " " + tokill.LastKnownLocation + " " + tokill.TimeStamp);



            //Console.WriteLine(Mohammed.getscure());
            //Console.WriteLine(QualityScore.voQualityScore().Name);
            //Console.WriteLine(QualityScore.voQualityScore().Rank);
            //Console.WriteLine(QualityScore.voQualityScore().getscure());


            //Console.WriteLine(funn(QualityScore.voQualityScore()));
            //foreach(TerroristReport a in IntelligenceUnit.ListReports)
            //{
            //    if (a.TerroristInformition == QualityScore.voQualityScore())
            //    {
            //        Console.WriteLine(a.LastKnownLocation);
            //    }
            //}

            //Console.WriteLine(Mohammed.Weapons.Keys);

            //foreach(StrikeUnit s in IDF.ListOfStrikUnits)
            //{
            //    Console.WriteLine(s.UnicName);
            //    //Console.WriteLine(s);
            //}
            //Console.WriteLine(f16.UnicName);
            //IDF.GetDateOfEstablishment();
        }
    }
}
