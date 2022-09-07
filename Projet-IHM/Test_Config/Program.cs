using System;
using System.Collections.Generic;
using Modele;

namespace Test_Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Test de la classe Config : \n");

            List<ComposantPrincipale> list = new List<ComposantPrincipale>();

            list.Add(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            list.Add(new ComposantPrincipale("Carte graphique NVDIA Geforce MX 130", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));
            

            Config conf1 = new Config(list);

            foreach(ComposantPrincipale composant in conf1.ListComposants)
            {
                Console.WriteLine(composant);
            }
            */

            // alimentation entre 300 et 1600 (350/400/450/1000/1200)

            string capacite = "410";
            int nb = 0;
            int tailleMot = capacite.Length;


            foreach (char str in capacite)
            {
                switch(str)
                {
                    case '0':

                        break;
                    case '1':
                        nb += (int)(1 * Math.Pow(10, tailleMot-1));

                        break;

                    case '2':
                        nb += (int)(2 * Math.Pow(10, tailleMot-1));

                        break;

                    case '3':
                        nb += (int)(3 * Math.Pow(10, tailleMot-1));

                        break;

                    case '4':
                        nb += (int)(4 * Math.Pow(10, tailleMot-1));

                        break;

                    case '5':
                        nb += (int)(5 * Math.Pow(10, tailleMot-1));

                        break;

                    case '6':
                        nb += (int)(6 * Math.Pow(10, tailleMot-1));

                        break;

                    case '7':
                        nb += (int)(7 * Math.Pow(10, tailleMot-1));

                        break;

                    case '8':
                        nb += (int)(8 * Math.Pow(10, tailleMot-1));

                        break;

                    case '9':
                        nb += (int)(9 * Math.Pow(10, tailleMot-1));

                        break;

                    default:
                        Console.WriteLine("echec");

                        break;
                }

                tailleMot--;

            }

            Console.WriteLine(nb);

            /*
            if(compteurZero == 0)
            {
                Console.WriteLine("Mauvais nombre");
            }
            else if(tailleMot-1 == compteurZero)
            {
                nb = capacite[0];
                Console.WriteLine(nb);
                nb = (int)(nb * Math.Pow(10 ,compteurZero));
                Console.WriteLine(nb);
            }
            else
            {
                nb = capacite[1] + capacite[0]*10;
                Console.WriteLine(nb);
                nb = (int)(nb* Math.Pow(10 ,compteurZero));
                Console.WriteLine(nb);

            }

            Console.WriteLine(nb);
            */
        }
    }
}
