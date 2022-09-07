using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace Persistance
{
    public class StubPersistance: IdbManager
    {

        private Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> composantPrincipauxCharge = new Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>>();

        private List<ComposantOptionnel> composantOptionnelCharge = new List<ComposantOptionnel>();

        private List<WishList> Fav;


        public (Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> CompoPrincRetrieve, List<WishList> WishListRetrieve, List<ComposantOptionnel> CompoOptRetrieve) ChargeDonneesComposant()
        {
            return (composantPrincipauxCharge, Fav, composantOptionnelCharge);
        }

        public void SauvegardeDonneeComposant(Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> composantPrincipaux, List<WishList> WishListASave, List<ComposantOptionnel> CompoOptASave)
        {
            Debug.WriteLine("Sauvegarde Demandé");
        }


        public StubPersistance()
        {

            /// Chargement de la liste de processeur dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur] = new List<ComposantPrincipale>();


            //Caractéristique en mili^mètre 
            //Poids en gramme
            //Frequence en GHz
            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Processeur Ryzen 9 5950X", "AMD", "AMD Ryzen 9 5950X", 550, "https://www.amazon.fr/dp/B0815Y8J9N?tag=gamertop-21&linkCode=osi&th=1", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int>{
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 56} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.4"},
                                                {Caracteristique.NbCoeur, "16"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "105" },
                                                {Caracteristique.Frequence_modeTurbo, "4.9"} }, "R9_5950.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Processeur Ryzen 9 5900X", "AMD", "AMD Ryzen 9 5900X", 429, "https://www.amazon.fr/AMD-Ryzen-9-5900X-RyzenTM/dp/B08164VTWH", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 56} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.7"},
                                                {Caracteristique.NbCoeur, "12"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "105"},
                                                {Caracteristique.Frequence_modeTurbo, "4.8"}}, "R9_5900.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 7 5800X", "AMD", "Ryzen 7 5800X", 429, "https://www.ldlc.com/fiche/PB00387534.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 113} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.8"},
                                                {Caracteristique.NbCoeur, "8"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "105"},
                                                {Caracteristique.Frequence_modeTurbo, "4.7"} }, "R7_5800X.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 7 5700X", "AMD", "Ryzen 7 5700X", 369, "https://www.ldlc.com/fiche/PB00493651.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 119} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.4"},
                                                {Caracteristique.NbCoeur, "8"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "65"},
                                            {Caracteristique.Frequence_modeTurbo, "4.6"}}, "R7_5700X.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 5 5600 Wraith Stealth", "AMD", "Ryzen 5 5600 Wraith Stealth", 252, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2020   , 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 425} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.5"},
                                                {Caracteristique.NbCoeur, "6"},
                                                {Caracteristique.Socket, "AM4"}, 
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.4"}}, "R5_5600.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 5 5500 Wraith Stealth", "AMD", "Ryzen 5 5500 Wraith Stealth", 178, "https://www.ldlc.com/fiche/PB00493654.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 431} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.6"},
                                                {Caracteristique.NbCoeur, "6"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.2"}}, "R5_5500.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 5 4500 Wraith Stealth", "AMD", "Ryzen 5 4500 Wraith Stealth", 144, "https://www.ldlc.com/fiche/PB00497548.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 400} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.6"},
                                                {Caracteristique.NbCoeur, "6"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.1"}}, "R5_4500.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 3 4100 Wraith Stealth", "AMD", "Ryzen 3 4100 Wraith Stealth", 119, "https://www.ldlc.com/fiche/PB00497776.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 510} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.8"},
                                                {Caracteristique.NbCoeur, "4"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.0"}}, "R3_4100.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("AMD Ryzen 3 3200G", "AMD", "Ryzen 3 3200G", 124, "https://www.ldlc.com/fiche/PB00431950.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 40},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 120} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.6"},
                                                {Caracteristique.NbCoeur, "4"},
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.0"}}, "R3_3200G.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i9-12900K", "Intel", "i9-12900K", 959, "https://www.ldlc.com/fiche/PB00490562.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 13}, 
                                            {CaracteristiquePhysique.Largeur, 14}, 
                                            {CaracteristiquePhysique.Hauteur, 16}, 
                                            {CaracteristiquePhysique.Poids, 460} }, 
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.4"},
                                                {Caracteristique.NbCoeur, "16"},
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Frequence_modeTurbo, "5.5"}}, "I9_12900K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i9-11900K", "Intel", "i9-11900K", 579, "https://www.ldlc.com/fiche/PB00421683.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 8},
                                            {CaracteristiquePhysique.Hauteur, 15},
                                            {CaracteristiquePhysique.Poids, 70} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.5"},
                                                {Caracteristique.NbCoeur, "8"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Frequence_modeTurbo, "5.3"}}, "i9_11900K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i9-10900K", "Intel", "i9-10900K", 549, "https://www.ldlc.com/fiche/PB00337259.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 8},
                                            {CaracteristiquePhysique.Largeur, 12},
                                            {CaracteristiquePhysique.Hauteur, 14},
                                            {CaracteristiquePhysique.Poids, 100} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.7"},
                                                {Caracteristique.NbCoeur, "10"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Frequence_modeTurbo, "5.3"}}, "i9_10900K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i7-12700K", "Intel", "Core i7-12700K", 546, "https://www.ldlc.com/fiche/PB00464925.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 18},
                                            {CaracteristiquePhysique.Largeur, 18},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 80} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.6"},
                                                {Caracteristique.NbCoeur, "12"},
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Frequence_modeTurbo, "5.0"}}, "i7_12700K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i7-11700F", "Intel", "Core i7-11700K", 389, "https://www.ldlc.com/fiche/PB00421716.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 12},
                                            {CaracteristiquePhysique.Largeur, 4},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 325} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2.5"},
                                                {Caracteristique.NbCoeur, "12"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.9"}}, "i7_11700K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i5-12600K", "Intel", "Core i5-12600K", 379, "https://www.ldlc.com/fiche/PB00464927.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 5},
                                            {CaracteristiquePhysique.Largeur, 5},
                                            {CaracteristiquePhysique.Hauteur, 5},
                                            {CaracteristiquePhysique.Poids, 40} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.7"},
                                                {Caracteristique.NbCoeur, "10"},
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Frequence_modeTurbo, "4.9"}}, "i5_12600K.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i5-12400F", "Intel", "Core i5-12400F", 247, "https://www.ldlc.com/fiche/PB00472404.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 30},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 300} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2.5"},
                                                {Caracteristique.NbCoeur, "6"},
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.4"}}, "i5_12400F.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i5-11400", "Intel", "Core i5-11400", 224, "https://www.ldlc.com/fiche/PB00463443.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 70},
                                            {CaracteristiquePhysique.Largeur, 10},
                                            {CaracteristiquePhysique.Hauteur, 12},
                                            {CaracteristiquePhysique.Poids, 310} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2.6"},
                                                {Caracteristique.NbCoeur, "6"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.4"}}, "i5_11400.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i3-12100F", "Intel", "Core i3-12100F", 169, "https://www.ldlc.com/fiche/PB00473446.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 30},
                                            {CaracteristiquePhysique.Largeur, 20},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 300} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.3"},
                                                {Caracteristique.NbCoeur, "4"},
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.Consommation, "58"},
                                                {Caracteristique.Frequence_modeTurbo, "4.3"}}, "i3_12100F.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i3-10105", "Intel", "Core i3-10105", 149, "https://www.ldlc.com/fiche/PB00421712.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 50},
                                            {CaracteristiquePhysique.Largeur, 50},
                                            {CaracteristiquePhysique.Hauteur, 15},
                                            {CaracteristiquePhysique.Poids, 70} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.7"},
                                                {Caracteristique.NbCoeur, "4"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.4"}}, "i3_10105.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Processeur].Add(new ComposantPrincipale("Intel Core i3-10100F", "Intel", "Core i3-10100F", 93, "https://www.ldlc.com/fiche/PB00384191.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 12},
                                            {CaracteristiquePhysique.Largeur, 7},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 270} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3.6"},
                                                {Caracteristique.NbCoeur, "4"},
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.Consommation, "65"},
                                                {Caracteristique.Frequence_modeTurbo, "4.3"}}, "i3_10100F.png"));



            /// Chargement de la liste de carte graphique dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("AMD Radeon RX 6600 Challenger ITX 8GB", "ASRock", "RX6600 CLI 8G", 679, "https://www.ldlc.com/fiche/PB00465684.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 179},
                                            {CaracteristiquePhysique.Largeur, 124},
                                            {CaracteristiquePhysique.Hauteur, 40},
                                            {CaracteristiquePhysique.Poids, 441} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1626"},
                                                {Caracteristique.Consommation, "170"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "8"},
                                                {Caracteristique.Connectiques, "2x Display Port, 2x HDMI"},
                                                {Caracteristique.LedRGB, "Non"}}, "RX6600.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce RTX 3060 VENTUS 2X 12G OC LHR", "MSI", "GEFORCE RTX 3060 VENTUS 2X 12G OC", 459, "https://www.ldlc.com/fiche/PB00408692.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 235},
                                            {CaracteristiquePhysique.Largeur, 124},
                                            {CaracteristiquePhysique.Hauteur, 42},
                                            {CaracteristiquePhysique.Poids, 479} },
                                new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1320"},
                                                {Caracteristique.Consommation, "170"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "12"},
                                                {Caracteristique.Connectiques, "3x Display Port, 1x HDMI"},
                                                {Caracteristique.LedRGB, "Non"}}, "RTX_3060_MSI.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce GTX 1660 Ti OC 6G", "Gigabyte", "GV-N166TOC-6GD", 399, "https://www.ldlc.com/fiche/PB00265834.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 224},
                                            {CaracteristiquePhysique.Largeur, 121},
                                            {CaracteristiquePhysique.Hauteur, 40},
                                            {CaracteristiquePhysique.Poids, 398} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1500"},
                                                {Caracteristique.Consommation, "120"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.GoRam, "6"},
                                                {Caracteristique.Connectiques, "3x Display Port, 1x HDMI"},
                                                {Caracteristique.LedRGB, "Non"}}, "GV-N166TOC-6GD.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce RTX 3070 Ti O8G GAMING (LHR)", "ASUS TUF", "90YV0GY0-M0NA00", 899, "https://www.ldlc.com/fiche/PB00447790.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 299},
                                            {CaracteristiquePhysique.Largeur, 129},
                                            {CaracteristiquePhysique.Hauteur, 51},
                                            {CaracteristiquePhysique.Poids, 427} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1815"},
                                                {Caracteristique.Consommation, "310"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "8"},
                                                {Caracteristique.Connectiques, "3x Display Port, 2x HDMI"},
                                                {Caracteristique.LedRGB, "Oui"}}, "90YV0EZ2-M0NA00.png"));;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce GTX 1650 OC 4G", "Gigabyte", "GV-N1650OC-4GD0", 229, "https://www.ldlc.com/fiche/PB00269987.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 191},
                                            {CaracteristiquePhysique.Largeur, 112},
                                            {CaracteristiquePhysique.Hauteur, 36},
                                            {CaracteristiquePhysique.Poids, 387} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1485"},
                                                {Caracteristique.Consommation, "75"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.GoRam, "4"},
                                                {Caracteristique.Connectiques, "1x Display Port, 2x HDMI"},
                                                {Caracteristique.LedRGB, "Non"}}, "GV-N1650OC-4GD0.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce RTX 3080 Ti O12G GAMING (LHR)", "ASUS ROG STRIX", "90YV0GT1-M0NM00", 1499, "https://www.ldlc.com/fiche/PB00438231.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 318},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 140},
                                            {CaracteristiquePhysique.Poids, 510} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2165"},
                                                {Caracteristique.Consommation, "350"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "12"},
                                                {Caracteristique.Connectiques, "3x Display Port, 2x HDMI"},
                                                {Caracteristique.LedRGB, "Oui"}}, "90YV0GY0-M0NA00.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("AMD Radeon RX 6700 XT MECH 2X 12G", "MSI", "Radeon RX 6700 XT MECH 2X 12G", 599, "https://www.ldlc.com/fiche/PB00412512.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 247},
                                            {CaracteristiquePhysique.Largeur, 131},
                                            {CaracteristiquePhysique.Hauteur, 51},
                                            {CaracteristiquePhysique.Poids, 426} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2321"},
                                                {Caracteristique.Consommation, "230"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "12"},
                                                {Caracteristique.Connectiques, "3x Display Port, 1x HDMI"},
                                                {Caracteristique.LedRGB, "Oui"}}, "RX_6700_XT.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("AMD Radeon RX 6750 XT Phantom Gaming D 12GB OC", "ASRock", "RX6750XT PGD 12GO", 599, "https://www.ldlc.com/fiche/PB00498415.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 305},
                                            {CaracteristiquePhysique.Largeur, 131},
                                            {CaracteristiquePhysique.Hauteur, 55},
                                            {CaracteristiquePhysique.Poids, 414} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "2554"},
                                                {Caracteristique.Consommation, "250"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                {Caracteristique.GoRam, "12"},
                                                {Caracteristique.Connectiques, "3x Display Port, 1x HDMI"},
                                                {Caracteristique.LedRGB, "Oui"}}, "RX6750XT.png"));



            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce GTX 1650 TUF-GTX1650-O4GD6-P-GAMING", "ASUS", "90YV0EZ2-M0NA00", 299, "https://www.ldlc.com/fiche/PB00354136.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 206},
                                            {CaracteristiquePhysique.Largeur, 125},
                                            {CaracteristiquePhysique.Hauteur, 46},
                                            {CaracteristiquePhysique.Poids, 378} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1410"},
                                                {Caracteristique.Consommation, "120"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.GoRam, "4"},
                                                {Caracteristique.Connectiques, "1x Display Port, 1x HDMI, 1x DVI"},
                                                {Caracteristique.LedRGB, "Non"}}, "90YV0EZ2-M0NA00.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_graphique].Add(new ComposantPrincipale("GeForce GTX 1660 SUPER VENTUS XS OC", "MSI", "GEFORCE GTX 1660 SUPER VENTUS XS OC", 399, "https://www.ldlc.com/fiche/PB00280144.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Carte_graphique, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 204},
                                            {CaracteristiquePhysique.Largeur, 128},
                                            {CaracteristiquePhysique.Hauteur, 42},
                                            {CaracteristiquePhysique.Poids, 403} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "1815"},
                                                {Caracteristique.Consommation, "125"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.GoRam, "6"},
                                                {Caracteristique.Connectiques, "3x Display Port, 1x HDMI"},
                                                {Caracteristique.LedRGB, "Non"}}, "GTX_1660_SUPER.png"));


            /// Chargement de la liste de carte mère dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("A320M Pro4-F", "ASRock", "A320M PRO4-F", 77, "https://www.ldlc.com/fiche/PB00335337.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 244},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 480} },
                                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.Format, "Micro-ATX"},
                                                {Caracteristique.LedRGB, "Non" } }, "A320M_PRO4-F.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("MPG B550 GAMING PLUS", "MSI", "MPG B550 GAMING PLUS", 139, "https://www.ldlc.com/fiche/PB00346104.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 305},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 508} },
                                new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "AM4"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "ATX"} ,
                                                {Caracteristique.LedRGB, "Non" } }, "MPG_B550.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("Z490-A-PRO", "MSI", "Z490-APRO", 199, "https://www.ldlc.com/fiche/PB00337229.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 303},
                                            {CaracteristiquePhysique.Largeur, 241},
                                            {CaracteristiquePhysique.Poids, 478} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "ATX"},
                                                {Caracteristique.LedRGB, "Non" } }, "Z490-APRO.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("B660M DS3H DDR4", "Gigabyte", "B660M DS3H DDR4", 134, "https://www.ldlc.com/fiche/PB00480611.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 244},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 458} },
                     new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "Micro-ATX"},
                                                {Caracteristique.LedRGB, "Oui" } }, "B660M_DS3H_DDR4.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("B360M MORTAR", "MSI", "B360M MORTAR", 69, "https://www.ldlc.com/fiche/PB00247926.html", new DateTime(2018, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 243},
                                            {CaracteristiquePhysique.Largeur, 243},
                                            {CaracteristiquePhysique.Poids, 450} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1151"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.Format, "Micro-ATX"},
                                                {Caracteristique.LedRGB, "Oui" } }, "B360M_MORTAR.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("B550-F GAMING (WI-FI) II", "ASUS ROG STRIX", "90MB19V0-M0EAY0", 214, "https://www.ldlc.com/fiche/PB00474551.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 305},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 4999} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "AMD4"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "ATX"},
                                                {Caracteristique.LedRGB, "Oui" } }, "90MB19V0-M0EAY0.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("Z490-E GAMING", "ASUS ROG STRIX", "90MB12P0-M0EAY0", 299, "https://www.ldlc.com/fiche/PB00337508.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 305},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 499} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "ATX"},
                                                {Caracteristique.LedRGB, "Oui" } }, "90MB12P0-M0EAY0.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("MAG B365M MORTAR", "MSI", "MAG B365M MORTAR", 99, "https://www.ldlc.com/fiche/PB00276759.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 243},
                                            {CaracteristiquePhysique.Largeur, 243},
                                            {CaracteristiquePhysique.Poids, 487} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1151"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.Format, "Micro-ATX"},
                                                {Caracteristique.LedRGB, "Non" } }, "MAG_B365M_MORTAR.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("PRO Z690-A DDR4", "MSI", "PRO Z690-A DDR4", 249, "https://www.ldlc.com/fiche/PB00464641.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 305},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 480} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1700"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 3" },
                                                {Caracteristique.Format, "ATX"},
                                                {Caracteristique.LedRGB, "Oui" } }, "PRO_Z690-A_DDR4.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Carte_mere].Add(new ComposantPrincipale("B560M DS3H V2", "Gigabyte", "B560M DS3H V2", 108, "https://www.ldlc.com/fiche/PB00464858.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 144},
                                            {CaracteristiquePhysique.Largeur, 244},
                                            {CaracteristiquePhysique.Poids, 462} },
                    new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Socket, "1200"},
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Slots, "PCI 4" },
                                                //{Caracteristique.slots, "PCI 3" },
                                                {Caracteristique.Format, "Micro-ATX"},
                                                {Caracteristique.LedRGB, "Non" } }, "B560M_DS3H_V2.png"));


            /// Chargement de la liste de stockage dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Seagate BarraCuda 2 To (ST2000DM008)", " Seagate Technology", "BarraCuda 2 To", 61, "https://www.ldlc.com/fiche/PB00254175.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 146},
                                            {CaracteristiquePhysique.Largeur, 101},
                                            {CaracteristiquePhysique.Hauteur, 20},
                                            {CaracteristiquePhysique.Poids, 490} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseRotation, "7200"},
                                                {Caracteristique.Capacite, "2000"},
                                                {Caracteristique.TailleCache, "256"} }, "BarraCuda_2_To.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Western Digital WD Red Plus 4 To", "Western Digital", "WD Red Plus 4 To", 114, "https://www.ldlc.com/fiche/PB00406872.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 147},
                                            {CaracteristiquePhysique.Largeur, 101},
                                            {CaracteristiquePhysique.Hauteur, 26},
                                            {CaracteristiquePhysique.Poids, 570} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseRotation, "5400"},
                                                {Caracteristique.Capacite, "4000"},
                                                {Caracteristique.TailleCache, "128"} }, "WD_Red_Plus_4_To.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Toshiba N300 4 To (HDWG440EZSTA)", "Toshiba", "N300 4 To", 129, "https://www.ldlc.com/fiche/PB00450676.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 147},
                                            {CaracteristiquePhysique.Largeur, 101},
                                            {CaracteristiquePhysique.Hauteur, 26},
                                            {CaracteristiquePhysique.Poids, 693} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseRotation, "7200"},
                                                {Caracteristique.Capacite, "4000"},
                                                {Caracteristique.TailleCache, "256"} }, "N300_4_To.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Western Digital WD Gold 6 To (WD6003FRYZ)", "Western Digita", "WD Gold 6 To", 255, "https://www.ldlc.com/fiche/PB00279213.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 147},
                                            {CaracteristiquePhysique.Largeur, 101},
                                            {CaracteristiquePhysique.Hauteur, 26},
                                            {CaracteristiquePhysique.Poids, 715} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseRotation, "7200"},
                                                {Caracteristique.Capacite, "6000"},
                                                {Caracteristique.TailleCache, "256"} }, "WD_Gold_6_To.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("WD_Black 3.5 Gaming Hard Drive 500 Go SATA 6Gb/s", "WD_Black", "3.5 Gaming Hard Drive 500 Go", 92, "https://www.ldlc.com/fiche/PB00134123.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 147},
                                            {CaracteristiquePhysique.Largeur, 101},
                                            {CaracteristiquePhysique.Hauteur, 26},
                                            {CaracteristiquePhysique.Poids, 430} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseRotation, "7200"},
                                                {Caracteristique.Capacite, "500"},
                                                {Caracteristique.TailleCache, "64"} }, "3.5_Gaming_Hard_Drive_500_Go.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Samsung SSD 980 M.2 PCIe NVMe 250 Go", "Samsung", "SSD 980 M.2 PCIe NVMe 250 Go", 59, "https://www.ldlc.com/fiche/PB00410700.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 80},
                                            {CaracteristiquePhysique.Largeur, 22},
                                            {CaracteristiquePhysique.Hauteur, 2},
                                            {CaracteristiquePhysique.Poids, 9} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseEcriture, "1300"},
                                                {Caracteristique.Capacite, "250"},
                                                {Caracteristique.VitesseLecture, "2900"} }, "SSD_980_M.2_PCIe_NVMe_250_Go.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Samsung SSD 870 QVO 1 To", "Samsung", "SSD 870 QVO 1 To", 99, "https://www.ldlc.com/fiche/PB00351654.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 100},
                                            {CaracteristiquePhysique.Largeur, 69},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 51} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseEcriture, "530"},
                                                {Caracteristique.Capacite, "1000"},
                                                {Caracteristique.VitesseLecture, "560"} }, "SSD_870_QVO_1_To.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Crucial BX500 480 Go", "Crucial", "BX500 480 Go", 54, "https://www.ldlc.com/fiche/PB00255699.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 100},
                                            {CaracteristiquePhysique.Largeur, 75},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 45} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseEcriture, "500"},
                                                {Caracteristique.Capacite, "480"},
                                                {Caracteristique.VitesseLecture, "540"} }, "BX500_480_Go.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Textorm B5 SSD 120 Go", "Textorm", "B5 SSD 120 Go", 24, "https://www.ldlc.com/fiche/PB00400746.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 100},
                                            {CaracteristiquePhysique.Largeur, 70},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 41} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseEcriture, "500"},
                                                {Caracteristique.Capacite, "120"},
                                                {Caracteristique.VitesseLecture, "550"} }, "B5_SSD_120_Go.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Stockage].Add(new ComposantPrincipale("Kingston SSD NV1 1 To", "Kingston", "SSD NV1 1 To", 109, "https://www.ldlc.com/fiche/PB00426125.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Stockage, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 80},
                                            {CaracteristiquePhysique.Largeur, 22},
                                            {CaracteristiquePhysique.Hauteur, 2},
                                            {CaracteristiquePhysique.Poids, 7} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.VitesseEcriture, "1700"},
                                                {Caracteristique.Capacite, "1000"},
                                                {Caracteristique.VitesseLecture, "2100" } }, "SSD_NV1_1_To.png"));


            /// Chargement de la liste de Boitier dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Seasonic SYNCRO Q704 + DGC-750 Gold", "Seasonic", "SYNCRO Q704", 369, "https://www.ldlc.com/fiche/PB00440699.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 493},
                                            {CaracteristiquePhysique.Largeur, 234},
                                            {CaracteristiquePhysique.Hauteur, 537},
                                            {CaracteristiquePhysique.Poids, 9600} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" }}, "SYNCRO_Q704.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Lian Li ODYSSEY X Noir", "Lian Li", "ODYSSEY X", 649, "https://www.ldlc.com/fiche/PB00460337.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 575},
                                            {CaracteristiquePhysique.Largeur, 234},
                                            {CaracteristiquePhysique.Hauteur, 558},
                                            {CaracteristiquePhysique.Poids, 12200} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "ODYSSEY_X.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Lian Li LANCOOL 205 Noir", "Lian Li", "LANCOOL 205", 129, "https://www.ldlc.com/fiche/PB00354141.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 415},
                                            {CaracteristiquePhysique.Largeur, 205},
                                            {CaracteristiquePhysique.Hauteur, 485},
                                            {CaracteristiquePhysique.Poids, 7550} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "LANCOOL_205.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Be Quiet! Pure Base 500DX (Noir)", "Be Quiet!", "1Pure Base 500DX", 129, "https://www.ldlc.com/fiche/PB00338646.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 450},
                                            {CaracteristiquePhysique.Largeur, 232},
                                            {CaracteristiquePhysique.Hauteur, 463},
                                            {CaracteristiquePhysique.Poids, 7800} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "1Pure_Base_500DX.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Phanteks Eclipse P360A (Noir)", "Phanteks", "Eclipse P360A", 119, "https://www.ldlc.com/fiche/PB00401172.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 465},
                                            {CaracteristiquePhysique.Largeur, 200},
                                            {CaracteristiquePhysique.Hauteur, 455},
                                            {CaracteristiquePhysique.Poids, 6700} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "Eclipse_P360A.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Antec DF800 FLUX Noir", "Antec", "DF800 FLUX", 99, "https://www.ldlc.com/fiche/PB00480925.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 479},
                                            {CaracteristiquePhysique.Largeur, 220},
                                            {CaracteristiquePhysique.Hauteur, 488},
                                            {CaracteristiquePhysique.Poids, 7580} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "DF800_FLUX.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Zalman R2 Noir", "Zalman", "R2", 47, "https://www.ldlc.com/fiche/PB00352153.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 420},
                                            {CaracteristiquePhysique.Largeur, 207},
                                            {CaracteristiquePhysique.Hauteur, 457},
                                            {CaracteristiquePhysique.Poids, 5400} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "R2.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Xigmatek Aquarius Plus ARGB (Blanc)", "Xigmatek", "Aquarius Plus ARGB", 219, "https://www.ldlc.com/fiche/PB00462570.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 415},
                                            {CaracteristiquePhysique.Largeur, 280},
                                            {CaracteristiquePhysique.Hauteur, 427},
                                            {CaracteristiquePhysique.Poids, 10500} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "Aquarius_Plus_ARGB_Blanc.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("MSI MAG SHIELD 110R", "MSI", "MAG SHIELD 110R", 89, "https://www.ldlc.com/fiche/PB00488907.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 390},
                                            {CaracteristiquePhysique.Largeur, 205},
                                            {CaracteristiquePhysique.Hauteur, 457},
                                            {CaracteristiquePhysique.Poids, 4300} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "ATX" } }, "MAG_SHIELD_110R.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Aerocool Cylon Mini (blanc)", "Aerocool", "Cylon Mini", 49, "https://www.ldlc.com/fiche/PB00277877.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 373},
                                            {CaracteristiquePhysique.Largeur, 186},
                                            {CaracteristiquePhysique.Hauteur, 381},
                                            {CaracteristiquePhysique.Poids, 2600} },
                                             new Dictionary<Caracteristique, string>{ 
                                                {Caracteristique.Format, "Micro-ATX" } }, "Cylon_Mini.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Zalman S4 Plus", "Zalman", "S4 Plus", 52, "https://www.ldlc.com/fiche/PB00314294.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 400},
                                            {CaracteristiquePhysique.Largeur, 206},
                                            {CaracteristiquePhysique.Hauteur, 458},
                                            {CaracteristiquePhysique.Poids, 3700} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "S4_Plus.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Corsair Carbide 275R (Noir)", "Corsair", "Carbide 275R", 89, "https://www.ldlc.com/fiche/PB00248851.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 460},
                                            {CaracteristiquePhysique.Largeur, 215},
                                            {CaracteristiquePhysique.Hauteur, 455},
                                            {CaracteristiquePhysique.Poids, 8560} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "Carbide_275R.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Cooler Master MasterBox MB511 RGB (Noir)", "Cooler Master Ltd", "MasterBox MB511 RGB", 99, "https://www.ldlc.com/fiche/PB00264226.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 496},
                                            {CaracteristiquePhysique.Largeur, 217},
                                            {CaracteristiquePhysique.Hauteur, 469},
                                            {CaracteristiquePhysique.Poids, 7040} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "MasterBox_MB511_RGB.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("MSI MAG VAMPIRIC 010", "MSI", "MAG VAMPIRIC 010", 99, "https://www.ldlc.com/fiche/PB00273680.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 420},
                                            {CaracteristiquePhysique.Largeur, 210},
                                            {CaracteristiquePhysique.Hauteur, 475},
                                            {CaracteristiquePhysique.Poids, 7400} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "MAG_VAMPIRIC_010.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Corsair iCUE 220T RGB Tempered Glass", "Corsair", "iCUE 220T RGB Tempered Glass", 119, "https://www.ldlc.com/fiche/PB00313696.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 390},
                                            {CaracteristiquePhysique.Largeur, 210},
                                            {CaracteristiquePhysique.Hauteur, 450},
                                            {CaracteristiquePhysique.Poids, 6500} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "iCUE_220T_RGB_Tempered_Glass.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("BitFenix Nova TG (Blanc)", "BitFenix", "Nova TG", 69, "https://www.ldlc.com/fiche/PB00245786.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 465},
                                            {CaracteristiquePhysique.Largeur, 201},
                                            {CaracteristiquePhysique.Hauteur, 437},
                                            {CaracteristiquePhysique.Poids, 5300} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Micro-ATX" } }, "NovaTG.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Be Quiet! Silent Base 802 (Blanc)", "Be Quiet!", "Silent Base 802", 197, "https://www.ldlc.com/fiche/PB00391488.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 553},
                                            {CaracteristiquePhysique.Largeur, 281},
                                            {CaracteristiquePhysique.Hauteur, 539},
                                            {CaracteristiquePhysique.Poids, 12590} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Mini-ATX" } }, "Silent_Base_802.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Enermax Marbleshell MS30 (Blanc)", "Enermax", "Marbleshell MS30", 78, "https://www.ldlc.com/fiche/PB00375114.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 424},
                                            {CaracteristiquePhysique.Largeur, 205},
                                            {CaracteristiquePhysique.Hauteur, 480},
                                            {CaracteristiquePhysique.Poids, 5750} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Mini-ATX" } }, "Marbleshell_MS30.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Fractal Design Define XL R2 Titanium Grey", "Fractal Design", "Define XL R2 Titanium", 219, "https://www.ldlc.com/fiche/PB00140807.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 560},
                                            {CaracteristiquePhysique.Largeur, 232},
                                            {CaracteristiquePhysique.Hauteur, 559},
                                            {CaracteristiquePhysique.Poids, 16400} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Mini-ATX" } }, "Marbleshell_MS30.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Boitier].Add(new ComposantPrincipale("Aerocool Cylon Pro Tempered Glass (Noir)", "Aerocool", "Cylon Pro Tempered Glass", 79, "https://www.ldlc.com/fiche/PB00272502.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Boitier, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 434},
                                            {CaracteristiquePhysique.Largeur, 219},
                                            {CaracteristiquePhysique.Hauteur, 491},
                                            {CaracteristiquePhysique.Poids, 4800} },
                                             new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Format, "Mini-ATX" } }, "Cylon_Pro_Tempered_Glass.png"));


            /// Chargement de la liste de ventirad dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("Dark Rock 4", "BE Quiet!", "BK021", 72, "https://www.ldlc.com/fiche/PB00248492.html", new DateTime(2018, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 96},
                                            {CaracteristiquePhysique.Largeur, 136},
                                            {CaracteristiquePhysique.Hauteur, 159},
                                            {CaracteristiquePhysique.Poids, 920} },
                     new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "21" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Non"}}, "BK021.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("CT405W", "Abkoncore", "ABKO-CPUCOOLER-T405W-SPECTRUM", 39, "https://www.ldlc.com/fiche/PB00345167.html", new DateTime(2020, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 75},
                                            {CaracteristiquePhysique.Largeur, 127},
                                            {CaracteristiquePhysique.Hauteur, 158},
                                            {CaracteristiquePhysique.Poids, 1104} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "36" },
                                                {Caracteristique.Connectiques, "4 Pins, RGB Adressable"},
                                                {Caracteristique.LedRGB, "Oui"}}, "ABKO-CPUCOOLER-T405W-SPECTRUM.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("Mirage 5", "Aerocool", "ACTC-MR90517.01", 44, "https://www.ldlc.com/fiche/PB00281218.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 100},
                                            {CaracteristiquePhysique.Largeur, 100},
                                            {CaracteristiquePhysique.Hauteur, 145},
                                            {CaracteristiquePhysique.Poids, 780} },
                       new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "30" },
                                                {Caracteristique.Connectiques, "4 Pins, RGB Adressable"},
                                                {Caracteristique.LedRGB, "Oui"}}, "ACTC-MR90517.01.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("AK-CC6603EP01", "Akasa", "AK-CC6603EP01", 18, "https://www.ldlc.com/fiche/PB00490119.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 95},
                                            {CaracteristiquePhysique.Largeur, 95},
                                            {CaracteristiquePhysique.Hauteur, 25},
                                            {CaracteristiquePhysique.Poids, 550} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "36" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Non"}}, "AK-CC6603EP01.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("AS500", "DeepCool", "R-AS500-BKNLMN-G", 79, "https://www.ldlc.com/fiche/PB00407283.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 164},
                                            {CaracteristiquePhysique.Largeur, 142},
                                            {CaracteristiquePhysique.Hauteur, 98},
                                            {CaracteristiquePhysique.Poids, 698} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "29" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Oui"}}, "R-AS500-BKNLMN-G.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("ETS-F40-FS ARGB", "Enermax", "ETS-F40-FS", 46, "https://www.ldlc.com/fiche/PB00428267.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 93},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 158},
                                            {CaracteristiquePhysique.Poids, 750} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "23" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Oui"}}, "ETS-F40-FS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("Cold Snap S92", "Fox Spirit", "Cold Snap S92", 24, "https://www.ldlc.com/fiche/PB00351569.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 83},
                                            {CaracteristiquePhysique.Largeur, 94},
                                            {CaracteristiquePhysique.Hauteur, 137},
                                            {CaracteristiquePhysique.Poids, 505} },
                        new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "23" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Non"}}, "Cold_Snap_92.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("Cold Snap S92", "Fox Spirit", "Cold Snap S92", 135, "https://www.ldlc.com/fiche/PB00280162.html", new DateTime(2019, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 161},
                                            {CaracteristiquePhysique.Largeur, 165},
                                            {CaracteristiquePhysique.Hauteur, 150},
                                            {CaracteristiquePhysique.Poids, 1320} },
                       new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "24" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Non"}}));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Ventirad].Add(new ComposantPrincipale("CNPS10X Optima II ", "Zalman", "CNPS10X OPTIMAII BLACK", 37, "https://www.ldlc.com/fiche/PB00278426.html", new DateTime(2021, 1, 1), TypeDeComposantPrincipale.Ventirad, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 132},
                                            {CaracteristiquePhysique.Hauteur, 85},
                                            {CaracteristiquePhysique.Poids, 740} },
           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "27" },
                                                {Caracteristique.Connectiques, "4 Pins"},
                                                {Caracteristique.LedRGB, "Oui"}}, "CNPS10X_OPTIMAII_WHITE.png"));


            /// Chargement de la liste de ventirad dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Corsair CV450 80PLUS Bronze", "Corsair", "CV450 80PLUS", 49, "https://www.ldlc.com/fiche/PB00313686.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 125},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1790} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "450" } }, "CV450_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Corsair CV550 80PLUS Bronze", "Corsair", "CV550 80PLUS", 59, "https://www.ldlc.com/fiche/PB00313685.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 125},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1870} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "550" } }, "CV550_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Corsair CV650 80PLUS Bronze", "Corsair", "CV650 80PLUS", 69, "https://www.ldlc.com/fiche/PB00313684.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 125},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1900} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "650" } }, "CV650_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Antec HCG650 Gold", "Antec", "HCG650", 104, "https://www.ldlc.com/fiche/PB00248245.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 140},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2040} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "650" }}, "HCG650.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Antec HCG750 Gold", "Antec", "HCG750", 114, "https://www.ldlc.com/fiche/PB00249605.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 140},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2110} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "750" }}, "HCG750.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Antec HCG850 Gold", "Antec", "HCG850 ", 139, "https://www.ldlc.com/fiche/PB00249609.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 140},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2460} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "850" }}, "HCG850.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Antec HCG1000 Gold", "Antec", "HCG1000 Gold", 199, "https://www.ldlc.com/fiche/PB00479457.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1880} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "1000" }}, "HCG1000.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Aerocool Aero Bronze 550W", "Aerocool", "Aero 550W", 69, "https://www.ldlc.com/fiche/PB00334795.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2000} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "550" }}, "Aero_550W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Aerocool Aero White 600W", "Aerocool", "Aero 600W", 69, "https://www.ldlc.com/fiche/PB00334806.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2000} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "600" }}, "Aero_600W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Aerocool Aero Bronze 650W", "Aerocool", "Aero 650W", 69, "", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2000} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "650" }}, "Aero_650W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Aerocool Aero White 700W", "Aerocool", "Aero 700W", 89, "https://www.ldlc.com/fiche/PB00334802.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2200} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "700" }}, "Aero_700W.png"));            

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Be Quiet! System Power 9 400W 80PLUS Bronze", "Be Quiet!", "System Power 9 400W 80PLUS", 52, "https://www.ldlc.com/fiche/PB00245107.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1820} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "400" }}, "System_Power_9_400W_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Be Quiet! System Power 9 500W 80PLUS Bronze", "Be Quiet!", "System Power 9 500W 80PLUS", 69, "https://www.ldlc.com/fiche/PB00245106.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1820} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "500" }}, "System_Power_9_500W_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Be Quiet! System Power 9 600W 80PLUS Bronze", "Be Quiet!", "Be Quiet! System Power 9 600W 80PLUS BronzS", 74, "https://www.ldlc.com/fiche/PB00245108.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1820} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "600" }}, "System_Power_9600W_80PLUS_Bronze.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Be Quiet! System Power 9 700W 80PLUS Bronze", "Be Quiet!", "System Power 9 700W 80PLUS", 87, "https://www.ldlc.com/fiche/PB00245109.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1820} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "700" }}, "System_Power_9_700W_80PLUS.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Cooler Master MWE Bronze 450W V2", "Cooler Master Ltd", "MWE 450W", 54, "https://www.ldlc.com/fiche/PB00387288.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1337} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "450" }}, "MWE_450W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Cooler Master MWE Bronze 650W V2", "Cooler Master Ltd", "MWE 650W", 72, "https://www.ldlc.com/fiche/PB00387291.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1272} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "650" }}, "MWE_650W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Cooler Master MWE Bronze 750W V2", "Cooler Master Ltd", "MWE 750W", 79, "https://www.ldlc.com/fiche/PB00387496.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 1421} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "750" }}, "MWE_750W.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Cooler Master MWE Gold 1050 Full Modular V2", "Cooler Master Ltd", "MWE 1050 Full Modular V2", 179, "https://www.ldlc.com/fiche/PB00474613.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2170} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "1050" }}, "MWE_1050_Full_Modular_V2.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Alimentation].Add(new ComposantPrincipale("Cooler Master MWE Gold 1250 Full Modular V2", "Cooler Master Ltd", "MWE Gold 1250 Full Modular V2", 199, "https://www.ldlc.com/fiche/PB00474612.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Alimentation, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 160},
                                            {CaracteristiquePhysique.Largeur, 150},
                                            {CaracteristiquePhysique.Hauteur, 86},
                                            {CaracteristiquePhysique.Poids, 2170} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Puissance, "1250" }}, "MWE_Gold_1250_Full_Modular_V2.png"));



            /// Chargement de la liste de RAM dans le dictionnaire
            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive] = new List<ComposantPrincipale>();

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Kingston FURY Beast 16 Go DDR4 3733 MHz CL19", "Kingston", "FURY Beast 16 Go DDR4", 114, "https://www.ldlc.com/fiche/PB00446533.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 133},
                                            {CaracteristiquePhysique.Largeur, 34},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 36} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3733" } }, "FURY_Beast_16_Go_DDR4.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Kingston FURY Beast 8 Go DDR4 3733 MHz CL19", "Kingston", "FURY Beast 8 Go DDR4", 58, "https://www.ldlc.com/fiche/PB00446856.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 133},
                                            {CaracteristiquePhysique.Largeur, 34},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 36} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3733" } }, "FURY_Beast_8_Go_DDR4.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Corsair Vengeance LPX Series Low Profile 32 Go (2x 16 Go) DDR4", "Corsair", "Vengeance LPX Series Low Profile 32 Go (2x 16 Go) DDR4", 189, "https://www.ldlc.com/fiche/PB00271616.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 135},
                                            {CaracteristiquePhysique.Largeur, 34},
                                            {CaracteristiquePhysique.Hauteur, 7},
                                            {CaracteristiquePhysique.Poids, 18} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3200" } }, "Vengeance_LPX_Series_Low_Profile_32_Go__2x_16_Go__DDR4.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Corsair Dominator Platinum DDR5 32 Go (2 x 16 Go) 5600 MHz CL36 - Blanc", "Corsair", "Dominator Platinum DDR5 32 Go (2 x 16 Go)", 507, "https://www.ldlc.com/fiche/PB00481200.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 135},
                                            {CaracteristiquePhysique.Largeur, 56},
                                            {CaracteristiquePhysique.Hauteur, 8},
                                            {CaracteristiquePhysique.Poids, 90} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR5"},
                                                {Caracteristique.Debit_transfert, "5600" } }, "Dominator_Platinum_DDR5_32_Go__2x16_Go_.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Textorm 8 Go DDR4 3200 MHz CL16", "Textorm", "8 Go DDR4", 49, "https://www.ldlc.com/fiche/PB00392667.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 130},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 50} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3200" } }, "8_Go_DDR4.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Textorm 16 Go DDR4 3200 MHz CL16", "Textorm", "16 Go DDR4", 89, "https://www.ldlc.com/fiche/PB00392685.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 130},
                                            {CaracteristiquePhysique.Largeur, 40},
                                            {CaracteristiquePhysique.Hauteur, 6},
                                            {CaracteristiquePhysique.Poids, 18} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3200" } }, "16_Go_DDR4.png")); ;

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("G.Skill Aegis 16 Go (2 x 8 Go) DDR4 2666 MHz CL19", "G.Skill", "Aegis 16 Go (2 x 8 Go) DDR4", 90, "https://www.ldlc.com/fiche/PB00248769.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 150},
                                            {CaracteristiquePhysique.Largeur, 122},
                                            {CaracteristiquePhysique.Hauteur, 15},
                                            {CaracteristiquePhysique.Poids, 80} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "2666" } }, "Aegis_16_Go__2x8_Go__DDR4.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("G.Skill Value 8 Go DDR4 2666 MHz CL19", "G.Skill", "Value 8 Go DDR4", 43, "https://www.ldlc.com/fiche/PB00248764.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 170},
                                            {CaracteristiquePhysique.Largeur, 70},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 70} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "2666" } }, "Value_8_Go_DDR4.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Ballistix Black 16 Go (2 x 8 Go) DDR4 3600 MHz CL16", "Ballistix", "Black 16 Go (2 x 8 Go) DDR4", 119, "https://www.ldlc.com/fiche/PB00313983.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 155},
                                            {CaracteristiquePhysique.Largeur, 90},
                                            {CaracteristiquePhysique.Hauteur, 10},
                                            {CaracteristiquePhysique.Poids, 200} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3600" } }, "Black_16_Go__2x8_Go__DDR4.png"));

            composantPrincipauxCharge[TypeDeComposantPrincipale.Memoire_vive].Add(new ComposantPrincipale("Fox Spirit Akura RGB 32 Go (2x 16 Go) DDR4 3600 MHz CL18", "Fox Spirit", "Akura RGB 32 Go (2x 16 Go) DDR4", 189, "https://www.ldlc.com/fiche/PB00458460.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Memoire_vive, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 135},
                                            {CaracteristiquePhysique.Largeur, 56},
                                            {CaracteristiquePhysique.Hauteur, 8},
                                            {CaracteristiquePhysique.Poids, 90} },
                                            new Dictionary<Caracteristique, string> {
                                                {Caracteristique.TypeDeMemoire, "DDR4"},
                                                {Caracteristique.Debit_transfert, "3600" } }, "Akura_RGB_32_Go__2x16_Go__DDR4.png"));


            /// Chargement des composants optionnels dans le dictionnaire
            composantOptionnelCharge.Add(new ComposantOptionnel("ASUS Xonar AE", "ASUS", "Xonar AE", 84, "https://www.ldlc.com/fiche/PB00240189.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 190},
                                            {CaracteristiquePhysique.Largeur, 13},
                                            {CaracteristiquePhysique.Hauteur, 22},
                                            {CaracteristiquePhysique.Poids, 209} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.CAN, "24/192"},
                                                {Caracteristique.CNA, "24/192"} }, "Xonar_AE.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("ASUS Strix Soar", "ASUS", "Strix Soar", 116, "https://www.ldlc.com/fiche/PB00196830.html", new DateTime(2015, 9, 25), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 130},
                                            {CaracteristiquePhysique.Largeur, 190},
                                            {CaracteristiquePhysique.Hauteur, 22},
                                            {CaracteristiquePhysique.Poids, 500} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.CAN, "24/96"},
                                                {Caracteristique.CNA, "24/96"}}, "Strix_Soar.png" ));

            composantOptionnelCharge.Add(new ComposantOptionnel("TP-LINK TL-WN881ND", "TP - LINK", "TL - WN881ND", 19, "https://www.ldlc.com/fiche/PB00126311.html", new DateTime(2011, 9, 7), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 79},
                                            {CaracteristiquePhysique.Largeur, 122},
                                            {CaracteristiquePhysique.Hauteur, 20},
                                            {CaracteristiquePhysique.Poids, 60} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Bluetooth, "Non"} }, "TL-WN881ND.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("ASUS PCE-AX1800", "ASUS", "PCE-AX1800", 55, "https://www.ldlc.com/fiche/PB00487856.html", new DateTime(2022, 2, 1), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 80},
                                            {CaracteristiquePhysique.Largeur, 130},
                                            {CaracteristiquePhysique.Hauteur, 25},
                                            {CaracteristiquePhysique.Poids, 150} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Bluetooth, "Oui"} } , "PCE-AX1800.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("Gigabyte GC - WBAX210", "Gigabyte", "GC - WBAX210", 79, "https://www.ldlc.com/fiche/PB00428249.html", new DateTime(2019, 9, 12), TypeDeComposantOptionnel.Carte_reseau, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 80},
                                            {CaracteristiquePhysique.Largeur, 130},
                                            {CaracteristiquePhysique.Hauteur, 25},
                                            {CaracteristiquePhysique.Poids, 120} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Bluetooth, "Oui"}, },  "GC-WBAX210.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("Be Quiet! Pure Wings 2 120mm PWM High-Speed", "Be Quiet!", "Pure Wings 2", 11, "https://www.ldlc.com/fiche/PB00264734.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Ventilateur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 154},
                                            {CaracteristiquePhysique.Largeur, 120},
                                            {CaracteristiquePhysique.Hauteur, 28},
                                            {CaracteristiquePhysique.Poids, 131} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "36.9"},
                                                {Caracteristique.VitesseRotation, "2000"},
                                                {Caracteristique.LedRGB, "Non"},}, "Pure_Wings_2.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("Cooler Master MasterFan MF140 Halo ARGB", "Cooler Master Ltd", "MasterFan MF140 Halo ARGB", 18, "https://www.ldlc.com/fiche/PB00438560.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Ventilateur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 140},
                                            {CaracteristiquePhysique.Largeur, 140},
                                            {CaracteristiquePhysique.Hauteur, 25},
                                            {CaracteristiquePhysique.Poids, 212} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "30"},
                                                {Caracteristique.VitesseRotation, "1500"},
                                                {Caracteristique.LedRGB, "Oui"},}, "MasterFan_MF140_Halo_ARGB.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("Noctua NF-F12 PWM", "Noctua", "NF-F12 PWM", 26, "https://www.ldlc.com/fiche/PB00123799.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Ventilateur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 120},
                                            {CaracteristiquePhysique.Largeur, 120},
                                            {CaracteristiquePhysique.Hauteur, 25},
                                            {CaracteristiquePhysique.Poids, 300} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Niveau_Sonore, "22"},
                                                {Caracteristique.VitesseRotation, "1500"},
                                                {Caracteristique.LedRGB, "Non"},}, "NF-F12_PWM.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("ASUS SDRW-08D2S-U Lite - Coloris Noir", "ASUS", "SDRW-08D2S-U Lite", 45, "https://www.ldlc.com/fiche/PB00123265.html", new DateTime(2013, 11, 26), TypeDeComposantOptionnel.GraveurLecteur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 146},
                                            {CaracteristiquePhysique.Largeur, 170},
                                            {CaracteristiquePhysique.Hauteur, 42},
                                            {CaracteristiquePhysique.Poids, 281} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.TailleCache, "1"}, }, "SDRW-08D2S-U_Lite.png"));

            composantOptionnelCharge.Add(new ComposantOptionnel("ASUS SDRW-08D2S-U Lite Blanc", "ASUS", "SDRW-08D2S-U", 45, "https://www.ldlc.com/fiche/PB00123414.html", new DateTime(2012, 7, 22), TypeDeComposantOptionnel.GraveurLecteur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 152},
                                            {CaracteristiquePhysique.Largeur, 131},
                                            {CaracteristiquePhysique.Hauteur, 21},
                                            {CaracteristiquePhysique.Poids, 200} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.TailleCache, "2"}, }, "SDRW-08D2S-U.png"));

        }

    }
}
