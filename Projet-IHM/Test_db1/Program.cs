using System;
using System.Collections.Generic;
using System.Linq;
using Modele;
using Persistance;

namespace Test_db1
{
    internal class Program
    {
        /// <summary>
        /// Le test est visuel, on vérifie dans les fichiers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Manager m = new Manager(new StubPersistance());


            m.ChargeDonneesComposant();


            m.DataBase = new DataContractPersistance();


            m.SauvegardeDonneeComposant();

            //m.ChargeDonneesComposantP();

        }
    }
}
