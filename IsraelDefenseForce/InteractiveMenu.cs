using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IsraelDefenseForce
{
    internal static class InteractiveMenu
    {
        public static void RunMenue()
        {
            string soldername;
            string code;
            do
            {
                Console.WriteLine("enter your name. ");
                soldername = Console.ReadLine();
                Console.WriteLine("enter the code. ");
                code = Console.ReadLine();
            }
            while (!Valedize.IsValid(soldername, code));

            string chuse;
            do
            {
                Console.WriteLine("press 1 to see the terrorist with the most reports. ");
                Console.WriteLine("press 2 to see the terrorist with the highest rank. ");
                Console.WriteLine("press 3 to see the terrorist with the hiest score. ");
                Console.WriteLine("press 4 to see all terorist names. ");
                Console.WriteLine("press 5 to see ditelse of a spesific terrorist. ");
                Console.WriteLine("press 6 to see all avilbol units for attak. ");
                Console.WriteLine("press 7 to attak a spsific terrorist");
                Console.WriteLine("press 8 to exit. ");

                chuse = Console.ReadLine();
                switch (chuse)
                {
                    case "1":
                        Console.WriteLine(IntelligenceUnit.GetTheterWithMostReports().Name);
                        break;
                    case "2":
                        Console.WriteLine(QualityScore.gethiranke().Name);
                        break;
                    case "3":
                        Console.WriteLine(QualityScore.voQualityScore().Name);
                        break;
                    case "4":
                        foreach (Terrorist terrorist in Hamas.ListOfTerrorist)
                        {
                            Console.WriteLine(terrorist.Name);
                        }
                        break;
                    case "5":
                        Console.WriteLine("enter the terorist name. ");
                        string nameter = Console.ReadLine();
                        if (SavdLogicDicshenaris.DicsheneryNameTerrorist().Keys.Contains(nameter))
                        {
                            DisplayingTheTerrorist_sDetails.DisplayingTerrorist(SavdLogicDicshenaris.DicsheneryNameTerrorist()[nameter]);
                        }
                        else
                        {
                            Console.WriteLine($"no terrorist namd {nameter} to chek names of terorist  prass 4");
                        }
                        break;
                    case "6":
                        IDF.GetListOfUnitsWithStrikesLeft();
                        break;
                    case "7":
                        Console.WriteLine("enter a name of terrorist. ");
                        string terattak = Console.ReadLine();
                        Console.WriteLine("enter  the number of shoots.");
                        int num;
                        string strnum = Console.ReadLine();
                        if (int.TryParse(strnum, out num))
                        {
                            if (SavdLogicDicshenaris.DicsheneryNameTerrorist().Keys.Contains(terattak))
                            {
                                Attack.attack(SavdLogicDicshenaris.DicsheneryNameTerrorist()[terattak], num, soldername);
                            }
                            else
                            {
                                Console.WriteLine($"no terrorist namd {terattak} to chek names of terorist  prass 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("not valid number");
                        }

                        break;
                    case "8":
                        Console.WriteLine("by take ker");
                        break;
                    default:
                        Console.WriteLine("not valid chuse");
                        break;
                }
            }
            while (chuse != "8");










        }
    }
}
