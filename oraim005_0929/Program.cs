﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraim005_0929
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("Bankjegy autómata");

            Console.WriteLine("A legkissebb címlet 1.000 Ft. A maximálisan felvehető összeg 300.000 Ft. ");
            Console.Write("Adja meg mekkora összeget kíván felvenni: ");
            int bekertossz = Convert.ToInt32(Console.ReadLine());

            int db10 = 0;
            int db5 = 0;
            int db1 = 0;

            if (bekertossz % 1000 == 0 && bekertossz < 300001)
            {
                db10 = bekertossz / 10000;
                bekertossz = bekertossz - (db10 * 10000);
            
                db5 = bekertossz / 5000;
                bekertossz = bekertossz - (db5 * 5000);
            
                db1 = bekertossz / 1000;


                Console.WriteLine(db10 + " * 10.000 = " + (db10 * 10000));
                Console.WriteLine(db5 + " * 5.000 = " + (db5 * 5000));
                Console.WriteLine(db1 + " * 1.000 = " + (db1 * 1000));
            }
            else
            {
                Console.WriteLine("Nem lehet kiadni a kívánt összeget.");
            }

            Console.ReadKey();
            Console.Clear();

            //------------------------------------------------------------------------------------------------------

            Console.WriteLine("2. feladat");
            Console.WriteLine("Utazási költségtérítés");


            Console.WriteLine("Add meg a megtett utat km-ben! ");
            double utazas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg az autó fogyasztását 100 km-er literben! ");
            double fogyasztas = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Add meg az üzemanyag árát ft-ban! ");
            double uzemar = Convert.ToDouble(Console.ReadLine()); 

            double uzemkoltseg = (utazas * fogyasztas * uzemar) / 100;
            if (utazas <= 100)
            {
                Console.WriteLine("Költségtérítés: {0} Ft.", uzemkoltseg);
            }
            else if (utazas > 100)
            {
                double koltsegter = uzemkoltseg + (utazas * 25);
                Console.WriteLine("Költségtérítés: {0} Ft.", koltsegter);
            }
            else
            {
                Console.WriteLine("Rosz értéket adtál meg.");
            }

            Console.ReadKey();
            Console.Clear();

            //------------------------------------------------------------------------------------------------------









            Console.ReadKey();
            Console.Clear();



        }
    }
}
