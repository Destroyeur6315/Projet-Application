using System;
using Xunit;
using Modele;

namespace Test_U_Composant
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, "AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", TypeDeComposantPrincipale.Stockage, TypeDeComposantOptionnel.Inconnu, 
                            "AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", TypeDeComposantPrincipale.Stockage, TypeDeComposantOptionnel.Inconnu)]
        [InlineData(true, "Intel Core i9-12900K", "Intel", "i9-12900K", TypeDeComposantPrincipale.Processeur, TypeDeComposantOptionnel.Inconnu,
                            "Intel Core i9-12900K", "Intel", "i9-12900K", TypeDeComposantPrincipale.Processeur, TypeDeComposantOptionnel.Inconnu)]
        [InlineData(true, "Intel Core i5-12400F", "Intel", "Core i5-12400F", TypeDeComposantPrincipale.Carte_mere, TypeDeComposantOptionnel.Inconnu,
                            "Intel Core i5-12400F", "Intel", "Core i5-12400F", TypeDeComposantPrincipale.Carte_mere, TypeDeComposantOptionnel.Inconnu)]
        [InlineData(true, "Intel Core i3-10105", "Intel", "Core i3-10105", TypeDeComposantPrincipale.Carte_graphique, TypeDeComposantOptionnel.Inconnu, 
                            "Intel Core i3-10105", "Intel", "Core i3-10105", TypeDeComposantPrincipale.Carte_graphique, TypeDeComposantOptionnel.Inconnu)]
        [InlineData(true, "AMD Radeon RX 6600 Challenger ITX 8GB", "ASRock", "RX6600 CLI 8G", TypeDeComposantPrincipale.Ventirad, TypeDeComposantOptionnel.Inconnu,
                            "AMD Radeon RX 6600 Challenger ITX 8GB", "ASRock", "RX6600 CLI 8G", TypeDeComposantPrincipale.Ventirad, TypeDeComposantOptionnel.Inconnu)]
        [InlineData(false, "ASUS Xonar AE", "ASUS", "Xonar AE", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Carte_reseau,
                           "ASUS Xonar AE", "ASUS", "Xonar AE", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Carte_reseau)]
        [InlineData(false, "ASUS Strix Soar", "ASUS", "Strix Soar", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Carte_Son,
                           "ASUS Strix Soar", "ASUS", "Strix Soar", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Carte_Son)]
        [InlineData(false, "TP-LINK TL-WN881ND", "TP - LINK", "TL - WN881ND", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.GraveurLecteur,
                            "TP-LINK TL-WN881ND", "TP - LINK", "TL - WN881ND", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.GraveurLecteur)]
        [InlineData(false, "ASUS PCE-AX1800", "ASUS", "PCE-AX1800", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Ventilateur,
                            "ASUS PCE-AX1800", "ASUS", "PCE-AX1800", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.Ventilateur)]
        [InlineData(false, "Be Quiet! Pure Wings 2 120mm PWM High-Speed", "Be Quiet!", "Pure Wings 2", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.GraveurLecteur,
                            "Be Quiet! Pure Wings 2 120mm PWM High-Speed", "Be Quiet!", "Pure Wings 2", TypeDeComposantPrincipale.Inconnu, TypeDeComposantOptionnel.GraveurLecteur)]
        public void testprotocoleEgalite(bool nb, string expectedDesignation, string expectedMarque, string expectedModele, TypeDeComposantPrincipale expectedTypedecomposant, TypeDeComposantOptionnel expectedTypedecomposantO,
                                            string designation, string marque, string modele, TypeDeComposantPrincipale typedecomposant, TypeDeComposantOptionnel TypedecomposantO)
        {


            if (nb)
            {
                ComposantPrincipale prod = new ComposantPrincipale(designation, marque, modele, 13, "ugpug", DateTime.Now, typedecomposant, null, null);
                ComposantPrincipale prod2 = new ComposantPrincipale(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposant, null, null);
                Assert.Equal(prod, prod2);

                ComposantPrincipale prod3 = new ComposantPrincipale(designation+1, marque, modele, 13, "ugpug", DateTime.Now, typedecomposant, null, null);
                ComposantPrincipale prod4 = new ComposantPrincipale(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposant, null, null);
                Assert.NotEqual(prod3, prod4);

                ComposantPrincipale prod5 = new ComposantPrincipale(designation, marque+1, modele, 13, "ugpug", DateTime.Now, typedecomposant, null, null);
                ComposantPrincipale prod6 = new ComposantPrincipale(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposant, null, null);
                Assert.NotEqual(prod5, prod6);

                ComposantPrincipale prod7 = new ComposantPrincipale(designation, marque, modele+1, 13, "ugpug", DateTime.Now, typedecomposant, null, null);
                ComposantPrincipale prod8 = new ComposantPrincipale(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposant, null, null);
                Assert.NotEqual(prod7, prod8);

                ComposantPrincipale prod9 = new ComposantPrincipale(designation, marque, modele, 13, "ugpug", DateTime.Now, TypeDeComposantPrincipale.Inconnu, null, null);
                ComposantPrincipale prod10 = new ComposantPrincipale(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposant, null, null);
                Assert.NotEqual(prod9, prod10);
            }
            else
            {
                ComposantOptionnel prod = new ComposantOptionnel(designation, marque, modele, 13, "ugpug", DateTime.Now, TypedecomposantO, null, null);
                ComposantOptionnel prod2 = new ComposantOptionnel(expectedDesignation, expectedMarque, expectedModele, 13, "ugpug", DateTime.Now, expectedTypedecomposantO, null, null);
                Assert.Equal(prod, prod2);
            }
        }
    }
}
