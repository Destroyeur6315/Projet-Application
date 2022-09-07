using System;
using Xunit;
using Modele;
using System.Collections.Generic;
using Persistance;

namespace Test_U_Manager
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 1, 0)]
        public void TestFonctionAddDeleteComposant(int expectednbComposant, int expectednbComposant2, int expectednbComposantOptionnel, int expectednbComposantOptionnel0)
        {
            Manager m = new Manager(new StubPersistance());

            m.AddComposantPrincipal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposant, m.Listecourante.Config.ListComposants.Count);

            m.AddComposantPrincipal(new ComposantPrincipale("MSI", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposant2, m.Listecourante.Config.ListComposants.Count);

            m.AddComposantOptionnel(new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposantOptionnel, m.Listecourante.ListComposantOptionnel.Count);

            m.DeleteComposantOptionnel(new ComposantOptionnel("MSI", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposantOptionnel, m.Listecourante.ListComposantOptionnel.Count);

            m.DeleteComposantOptionnel(new ComposantOptionnel("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantOptionnel.Carte_Son, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposantOptionnel0, m.Listecourante.ListComposantOptionnel.Count);

            m.DeleteComposantPrinicpal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            m.DeleteComposantPrinicpal(new ComposantPrincipale("MSI", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Carte_mere, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                           new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            Assert.Equal(expectednbComposantOptionnel0, m.Listecourante.Config.ListComposants.Count);

        }

        [Theory]
        [InlineData(0, 1, 2, 3)]
        public void TestFavoris(int expectedZeroListe, int expectedUneListe, int expectedDeuxListe, int expectedTroisListe)
        {
            Manager m = new Manager(new StubPersistance());

            m.AddComposantPrincipal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                        {CaracteristiquePhysique.Longueur, 10},
                                        {CaracteristiquePhysique.Largeur, 300},
                                        {CaracteristiquePhysique.Hauteur, 50},
                                        {CaracteristiquePhysique.Poids, 100} },
                                        new Dictionary<Caracteristique, string>{
                                            {Caracteristique.Frequence, "3000"},
                                            {Caracteristique.NbCoeur, "50"} }));


            string nom = m.listecourante.Nom;

            m.AddUneListeAuxFavoris();

            Assert.Equal(expectedUneListe, m.ListDesFavoris.Count);

            m.AddComposantPrincipal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                        {CaracteristiquePhysique.Longueur, 10},
                                        {CaracteristiquePhysique.Largeur, 300},
                                        {CaracteristiquePhysique.Hauteur, 50},
                                        {CaracteristiquePhysique.Poids, 100} },
                                       new Dictionary<Caracteristique, string>{
                                            {Caracteristique.Frequence, "3000"},
                                            {Caracteristique.NbCoeur, "50"} }));

            string nom2 = m.listecourante.Nom;

            m.AddUneListeAuxFavoris();

            Assert.Equal(expectedDeuxListe, m.ListDesFavoris.Count);

            m.AddComposantPrincipal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                        {CaracteristiquePhysique.Longueur, 10},
                                        {CaracteristiquePhysique.Largeur, 300},
                                        {CaracteristiquePhysique.Hauteur, 50},
                                        {CaracteristiquePhysique.Poids, 100} },
                                      new Dictionary<Caracteristique, string>{
                                            {Caracteristique.Frequence, "3000"},
                                            {Caracteristique.NbCoeur, "50"} }));

            string nom3 = m.listecourante.Nom;

            m.AddUneListeAuxFavoris();

            Assert.Equal(expectedTroisListe, m.ListDesFavoris.Count);

            m.DeleteUneListeDesFavoris(nom);

            Assert.Equal(expectedDeuxListe, m.ListDesFavoris.Count);

            m.DeleteUneListeDesFavoris(nom2);

            Assert.Equal(expectedUneListe, m.ListDesFavoris.Count);

            m.DeleteUneListeDesFavoris(nom3);

            Assert.Equal(expectedZeroListe, m.ListDesFavoris.Count);

        }

        [Theory]
        [InlineData("romain", "audric", "paul")]
        [InlineData("leo", "lea", "roro")]
        [InlineData("123", "1234", "12345")]
        [InlineData("Oui", "Non", "Oui")]

        public void testRenommageWishlist(string expectednom, string expectednom2, string expectednom3)
        {
            Manager m = new Manager(new StubPersistance());

            m.AddComposantPrincipal(new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                          new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"} }));

            string nom = m.listecourante.Nom;

            m.AddUneListeAuxFavoris();
            m.ChangeWishListName(nom, expectednom);
            m.ModifierUnelisteDesfavoris(expectednom);
            Assert.Equal(m.listecourante.Nom, expectednom);
            m.AddUneListeAuxFavoris();

            m.ChangeWishListName(expectednom, expectednom2);
            m.ModifierUnelisteDesfavoris(expectednom2);
            Assert.Equal(m.listecourante.Nom, expectednom2);
            m.AddUneListeAuxFavoris();

            m.ChangeWishListName(expectednom2, expectednom3);
            m.ModifierUnelisteDesfavoris(expectednom3);
            Assert.Equal(m.listecourante.Nom, expectednom3);
            m.AddUneListeAuxFavoris();
        }

        [Theory]
        [InlineData()]
        public void testChargerDonnees()
        {
            Manager m = new Manager(new StubPersistance());

            m.ChargeDonneesComposant();

            Assert.NotEmpty(m.ComposantPrincipaux);
            Assert.NotEmpty(m.ComposantOptionnel);

        }

    }
}
