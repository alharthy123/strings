﻿using System;
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
                Console.WriteLine("3:Beenden");

                Console.WriteLine("Aaswahl:");
                auswahl=Convert:Toint32(Console.ReadLine());

                switch(auswahl)
                {
                    case"1";
                Console.WriteLine("1:zelchen ersetzen.");
                        String zuErsetzen, zeichnen, erzatz;
                        Console.WriteLine("Zeichenkette eingeben:");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("welches Zeichen soll ersetzt werden?");
                        zeichnen = Console.ReadLine();
                        Console.WriteLine("wodurch soll" + zeichnen+ " ersetzt werden");
                        erzatz = Console.ReadLine();
                        Console.WriteLine("Es wird"zeichen+ "durch" + ersatzt + "erzetzt:");

                        String ersetzt = "";
                            for(int i=0; i< zuErsetzen.Length; i++)
                        {
                            if (zuErsetzen[i].ToString()==zeichen)
                            {
                                ersetzt += ersatz;
                            }
                            elso
                            {
                                ersetzt + -zuErsetzen[i];
                            }
                        }
                        Console.WriteLine(zuErsetzen + "wird zu:" + ersetzt);
                        break;
                    case "2":
                Console.WriteLine("2:Vokale entfernen.");
                        String zeichenkette;
                        Console.WriteLine(zeichnen 
                        break;
                    case"3":
                Console.WriteLine("3:Beenden")
                break;

                 default;


                }
                   




                Console.WriteLine("neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            }while (wiederholen=="j"||wiederholen"J");
            }
        }
    }
}
