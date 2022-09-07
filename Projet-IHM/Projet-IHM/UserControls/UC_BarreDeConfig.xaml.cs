using System;
using System.Collections.Generic;
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
using Modele;

namespace Projet_IHM
{
    /// <summary>
    /// Logique d'interaction pour UC_BarreDeConfig.xaml
    /// </summary>
    public partial class UC_BarreDeConfig : UserControl
    {

        /// <summary>
        /// Récuparation du manager instancié dans l'application courante
        /// </summary>
        Manager manager = (App.Current as App).LeManager;

        public UC_BarreDeConfig()
        {
            InitializeComponent();
        }


        public Composant CompoConfig
        {
            get { return (Composant)GetValue(CompoProperty); }
            set
            {
                SetValue(CompoProperty, value);
            }
        }


        public static readonly DependencyProperty CompoProperty =
            DependencyProperty.Register("CompoConfig", typeof(Composant), typeof(UC_BarreDeConfig), new PropertyMetadata(new Composant()));


        /// <summary>
        /// Supprimer un composant de la wishlist courante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supp_Click(object sender, RoutedEventArgs e)
        {
            manager.DeleteComposantOptionnel(CompoConfig as ComposantOptionnel);
            manager.DeleteComposantPrinicpal(CompoConfig as ComposantPrincipale);
        }
    }
}
