using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_IHM
{
    /// <summary>
    /// Logique d'interaction pour UC_Produit.xaml
    /// </summary>
    public partial class UC_Produit : UserControl
    {
        /// <summary>
        /// Récupération du manager instancié dans l'application courante
        /// </summary>
        Manager manager = (App.Current as App).LeManager;

        public UC_Produit()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Propriété qui récupère un composant bindé
        /// </summary>
        public Composant Compo
        {
            get { return (Composant)GetValue(CompoProperty); }
            set 
            { 
                SetValue(CompoProperty, value);
            }
        }


        public static readonly DependencyProperty CompoProperty =
            DependencyProperty.Register("Compo", typeof(Composant), typeof(UC_Produit), new PropertyMetadata(new Composant()));
    }
}
