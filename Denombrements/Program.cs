using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    /**
     * titre : Denombrements
     * description : programme permettant 3 types de calculs
     * date création : 13/06/2020
     * date dernière modification: 04/10/2022
     */
    class Program
    {
        static void saisie(string message)
        {
            Console.Write(message);
            int n = int.Parse(Console.ReadLine());
        }


            /// <summary>
            /// </summary>
            /// <param name="args"></param>
            /// Calcul de permutation arrangement et/ou combinaison
            static void Main(string[] args)
        {

            //Déclarations
            int c = 1;
            long r = 1;
            int n = 0;

            // Boucle sur le choix de la formule mathématique
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
                if (c == 0) 
                { 
                    Environment.Exit(0); 
                }

                if (c == 1)
                {
                    //demande et saisie d'un nombre
                    saisie("nombre total d'éléments à gérer");
                    // calcul de r
                    for (int k = 1; k <= n; k++)
                        r *= k;

                    //résultat permutation
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        saisie(" nombre total d'éléments à gérer: ");
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int t = int.Parse(Console.ReadLine());
                        // calcul de r
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //Résultat arrangement
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        saisie("nombre total d'éléments à gérer = ");
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int t = int.Parse(Console.ReadLine());

                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        //Résultat combinaison
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
