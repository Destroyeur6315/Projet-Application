using Modele;
using Persistance;
using System;
using System.Collections.Generic;

namespace Test_Compatibilite_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager Mgr = new Manager(new StubPersistance());

            Mgr.ChargeDonneesComposant();

            ComposantPrincipale composant1 = new ComposantPrincipale("AMD Ryzen 5 5600X Wraith Stealth", "AMD", "100-100000065BOX", 300, "https://www.ldlc.com/fiche/PB00387517.html", new DateTime(2022, 1, 1), TypeDeComposantPrincipale.Processeur, new Dictionary<CaracteristiquePhysique, int> {
                                            {CaracteristiquePhysique.Longueur, 10},
                                            {CaracteristiquePhysique.Largeur, 300},
                                            {CaracteristiquePhysique.Hauteur, 50},
                                            {CaracteristiquePhysique.Poids, 100} },
                                            new Dictionary<Caracteristique, string>{
                                                {Caracteristique.Frequence, "3000"},
                                                {Caracteristique.NbCoeur, "50"},
                                                {Caracteristique.Socket, "L1155"} });




            Mgr.AddComposantPrincipal(composant1);


            Mgr.Compatibilite(TypeDeComposantPrincipale.Carte_mere);

            foreach(var i in Mgr.CompoAffiche) 
            {
                Console.WriteLine(i);
            }


        }
    }
}
