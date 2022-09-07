using System;
using System.Collections.Generic;
using Modele;

namespace Test_WhisList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test classe WhisList : \n");

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

            list.Add(new ComposantPrincipale("MSI GeForce RTX 3080 Ti GAMING X TRIO 12G LHR", "GEFORCE RTX 3080 TI GAMING X TRIO 12G", "100-100000065BOX", 1455, "https://www.ldlc.com/fiche/PB00438240.html", new DateTime(2021, 10, 11), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 324},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 56},
                                            {CaracteristiquePhysique.Poids, 250} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.TypeDeMemoire, "GDDR6X"},
                                                {Caracteristique.LedRGB, "oui"} }));

            Config conf = new Config(list);

            List<ComposantOptionnel> listeOptionnel = new List<ComposantOptionnel>();

            ComposantOptionnel composant2 = new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} });

            ComposantOptionnel composant4= new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} });

            listeOptionnel.Add(composant4);
            listeOptionnel.Add(composant2);

            WishList test = new WishList("Config_Romain", conf, listeOptionnel);
            List<WishList> liste2 = new List<WishList>();

            liste2.Add(test);
            /*
            Console.WriteLine(test);

            Console.WriteLine("Les composants optionnels :");

            foreach(ComposantOptionnel composant in test.ListComposantOptionnel)
            {
                Console.WriteLine(composant);
            }

            Console.WriteLine("Les composants principaux :");

            foreach(ComposantPrincipale composant in test.Config.ListComposants)
            {
                Console.WriteLine(composant);
            }

            Console.WriteLine("***********************");
            */

            bool auau = true;

            romain(liste2);

            void romain(List<WishList> listecourant)
            {
                List<WishList> audric = new List<WishList>();

                listecourant.Remove(test);
            }

            foreach(var l in liste2) Console.WriteLine(l);

           

        }
    }
}
