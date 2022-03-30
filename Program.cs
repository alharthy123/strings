using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbeiten mit strings");
            String wiederholen;

            do
            {
                //Menü
                int auswahl;
                Console.WriteLine("1:zelchen ersetzen.");
                Console.WriteLine("2:Vokale entfernen.");
                Console.WriteLine("3:Quersumme bilden.");
                Console.WriteLine("3:Beenden.");

                Console.WriteLine("Aaswahl:");
                auswahl=Convert.ToInt32(Console.ReadLine());

                switch(auswahl)
                {
                    case 1:
                        Console.WriteLine("1:zelchen ersetzen.");
                        String zuErsetzen, zeichnen, ersatz;
                        Console.WriteLine("Zeichenkette eingeben:");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("welches Zeichen soll ersetzt werden?");
                        zeichnen = Console.ReadLine();
                        Console.WriteLine("wodurch soll" + zeichnen+ " ersetzt werden");
                        ersatz = Console.ReadLine();
                        Console.WriteLine("Es wird"+zeichnen+ "durch" + ersatz + "erzetzt:");

                        String ersetzt = "";
                        ersetzt = zuErsetzen.Replace(zeichnen, ersatz);
                        //    for (int i=0; i< zuErsetzen.Length; i++)
                        //    { 
                        //    if (zuErsetzen[i].ToString()== zeichnen )
                        //    {
                        //        ersetzt += ersatz;
                        //    }
                        //    else

                        //    {
                        //        ersetzt += zuErsetzen[i];
                        //    }
                        //}
                        Console.WriteLine(zuErsetzen + "wird zu:" + ersetzt);
                        break;
                    case 2:
                        Console.WriteLine("2:Vokale entfernen.");
                        String zeichenkette;
                        Console.WriteLine("zeichenkette eingeben:");
                        zeichenkette = Console.ReadLine();
                        String zeichenketteAlt ="";
                        String vokale = "aieouAIEOU";
                        string ersetzt2 = "";

                         for(int i =0;i < vokale.Length; i ++)
                         {
                            // zeichenkette = zeichenkette.Replace(vokale[i].ToString(),"");
                            for (int j = 0; i < vokale.Length;i++)
                            { 
                                
                                if (zeichenkette[j]==vokale[i])
                                {
                                ersetzt2 += "";
                                }
                                else
                                {
                                ersetzt2 += zeichenkette[i];
                                }

                            }
                          
                         }

                        Console.WriteLine(zeichenkette + "wird zu" + zeichenkette);
                        break;
                    case 3:
                        Console.WriteLine("Die Qursumme einer ganzer zahl soll berechnet werden.");




                       break;

                    default:
                        Console.WriteLine("Auswahl ungültig,");

                        break;
                }
                   




                Console.WriteLine("neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            }while (wiederholen == "j"|| wiederholen=="J");
            
        }
    }
}