using Modele;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test_U_Produit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300)]
        [InlineData("Intel Core i9-12900K", "Intel", "i9-12900K", 959, "Intel Core i9-12900K", "Intel", "i9-12900K", 959)]
        [InlineData("Intel Core i5-12400F", "Intel", "Core i5-12400F",247, "Intel Core i5-12400F", "Intel", "Core i5-12400F", 247)]
        [InlineData("Intel Core i3-10105", "Intel", "Core i3-10105", 149, "Intel Core i3-10105", "Intel", "Core i3-10105", 149)]
        [InlineData("AMD Radeon RX 6600 Challenger ITX 8GB", "ASRock", "RX6600 CLI 8G", 679, "AMD Radeon RX 6600 Challenger ITX 8GB", "ASRock", "RX6600 CLI 8G", 679)]
        public void testConstructeurProduit(string expectedDesignation, string expectedMarque, string expectedModele, float expectedprix, string designation, string marque, string modele, 
                        float prix)
        {
            Produit prod = new Produit(designation, marque, modele, prix);
            Assert.NotNull(prod);
            Assert.Equal(expectedDesignation, designation);
            Assert.Equal(expectedMarque, marque);
            Assert.Equal(expectedModele, modele);
            Assert.Equal(expectedprix, prix);
        }


    }
}
