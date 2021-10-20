/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2, solution, reponse = 0, choix; // mémorisation de nombres aléatoires, calcul de la solution, saisie de la réponse de l'utilisateur, saisie du choix de l'utilsiateur
            bool correct = false;
            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // traitement des choix
                while (!correct)
                {
                    try
                    {
                        // affiche le menu et saisi le choix
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }
                }
                correct = false;
                if (choix != 0)
                {
                    if (choix == 1 || choix == 2)
                    {
                        if (choix == 1)
                        {
                            // choix de l'addition
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            while (!correct)
                            {
                                try
                                {
                                    // saisie de la réponse
                                    Console.Write(val1 + " + " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                    correct = true;
                                }
                                catch
                                {
                                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                                }
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                        }
                        else
                        {
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            while (!correct)
                            {
                                try
                                {
                                    // saisie de la réponse
                                    Console.Write(val1 + " x " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                    correct = true;
                                }
                                catch
                                {
                                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                                }
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 * val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                        }
                        correct = false;
                    }
                    else
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entre 0, 1 et 2aaa");
                    }
                }
            }
        }
    }
}