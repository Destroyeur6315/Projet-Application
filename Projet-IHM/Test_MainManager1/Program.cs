using Persistance;
using System;
using Modele;
using System.Collections.Generic;

namespace Test_MainManager1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Config : \n");

            Manager m = new Manager(new StubPersistance());

            //m.SauvegardeDonneeComposantP();


            m.ChargeDonneesComposant();

            /*
            foreach (KeyValuePair<TypeDeComposantPrincipale, List<ComposantPrincipale>> kvp in m.ComposantPrincipaux)
            {
                Console.WriteLine($"{kvp.Key} =>");
                Console.WriteLine(kvp.Value.Count);

                foreach (var compoRetrieve in kvp.Value)
                {
                    Console.WriteLine(compoRetrieve);
                }
            }
            */

            ComposantPrincipale composant1 = new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} });

            ComposantPrincipale composant3 = new ComposantPrincipale("NVDIa MX 130", "NVDIA", "100-llfpdo20", 500, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} });

            ComposantOptionnel composant2 = new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} });

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

            m.AddComposantPrincipal(composant1);
            m.AddComposantPrincipal(composant3);

            m.AddComposantOptionnel(composant2);

            foreach(var composant in m.Listecourante.Config.ListComposants)
            {
                Console.WriteLine(composant);
            }

            foreach(var composant in m.Listecourante.ListComposantOptionnel)
            {
                Console.WriteLine(composant);
            }

            if(m.AddUneListeAuxFavoris()) Console.WriteLine("test");

            Console.WriteLine("*********************");

            foreach (var composant in m.Listecourante.Config.ListComposants)
            {
                Console.WriteLine(composant);
            }

            foreach (var composant in m.Listecourante.ListComposantOptionnel)
            {
                Console.WriteLine(composant);
            }

            Console.WriteLine("*********************");

            
            foreach(var liste in m.ListDesFavoris) Console.WriteLine(liste);

            // m.ChangeWishListName()


            /*
            manager.AddComposantPrincipale(wishList5, composant3);

            foreach (var liste in manager.ListDesFavoris)
            {
                Console.WriteLine(liste);
            }
            
            m.ChangeWishListName(wishList5, "config_Audric");
            m.ChangeWishListName(wishList, "config_Romain");
            */
            Console.WriteLine("\n");
            

        }
    }
}
