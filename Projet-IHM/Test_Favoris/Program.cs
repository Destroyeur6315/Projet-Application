using System;
using System.Collections.Generic;
using Modele;

namespace Test_Favoris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test classe Favoris : \n");

            Favoris favori = new Favoris(new WishList("Config_Audric", new Config(new ComposantPrincipale("MSI GeForce RTX 3080 Ti GAMING X TRIO 12G LHR", "GEFORCE RTX 3080 TI GAMING X TRIO 12G", "100-100000065BOX", 1455, "https://www.ldlc.com/fiche/PB00438240.html", new DateTime(2021, 10, 11), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 324},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 56},
                                            {CaracteristiquePhysique.Poids, 250} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.TypeDeMemoire, "GDDR6X"},
                                                {Caracteristique.LedRGB, "oui"} }),
                                                new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} })
                                             ), new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }), new ComposantOptionnel("MSI GeForce RTX 3080 Ti GAMING X TRIO 12G LHR", "MSI", "GEFORCE RTX 3080 TI GAMING X TRIO 12G", 1455, "https://www.ldlc.com/fiche/PB00438240.html", new DateTime(2021, 10, 11), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} })), new WishList("Config_Romain", new Config(new ComposantPrincipale("MSI GeForce RTX 3080 Ti GAMING X TRIO 12G LHR", "GEFORCE RTX 3080 TI GAMING X TRIO 12G", "100-100000065BOX", 1455, "https://www.ldlc.com/fiche/PB00438240.html", new DateTime(2021, 10, 11), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 324},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 56},
                                            {CaracteristiquePhysique.Poids, 250} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.TypeDeMemoire, "GDDR6X"},
                                                {Caracteristique.LedRGB, "oui"} }),
                                                new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} })
                                             ), new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }), new ComposantOptionnel("MSI GeForce RTX 3080 Ti GAMING X TRIO 12G LHR", "MSI", "GEFORCE RTX 3080 TI GAMING X TRIO 12G", 1455, "https://www.ldlc.com/fiche/PB00438240.html", new DateTime(2021, 10, 11), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} })));

            foreach(WishList wishlist in favori.ListWishList)
            {
                Console.WriteLine(wishlist);
            }



        }
    }
}
