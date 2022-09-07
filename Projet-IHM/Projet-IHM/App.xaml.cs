using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Modele;
using Persistance;

namespace Projet_IHM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; private set; } = new Manager(new DataContractPersistance());

        public Navigator Navigator { get; private set; } = new Navigator();

        public App()
        {
            LeManager.ChargeDonneesComposant();
        }
    }
}
