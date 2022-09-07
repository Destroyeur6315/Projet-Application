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

namespace Projet_IHM.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UC_ConfirmerRenommage.xaml
    /// </summary>
    public partial class UC_ConfirmerRenommage : UserControl
    {
        /// <summary>
        /// Récupération du manager instancié dans l'application courante
        /// </summary>
        public Manager Manager = (App.Current as App).LeManager;


        /// <summary>
        /// Récupération du Navigator instancié dans l'application courante
        /// </summary>
        public Navigator Navigator => (App.Current as App).Navigator;


        /// <summary>
        /// Nouveau nom pour la config
        /// </summary>
        public string NouveauNom { get; private set; }

        public UC_ConfirmerRenommage()
        {
            InitializeComponent();
            DataContext = Manager;
        }


        /// <summary>
        /// Change le nom de la wishList si bouton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValiderRenommage_Click(object sender, RoutedEventArgs e)
        {
            Manager.ChangeWishListName(Manager.NomWishlistAmodifier, NouveauNom);
            
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }


        /// <summary>
        /// Annuler le renommage de la Wishlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnnulerRenommage_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }


        /// <summary>
        /// Textbox d'entrée utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauNom_KeyUp(object sender, KeyEventArgs e)
        {
            string nouveauNom = (sender as TextBox).Text;

            NouveauNom = nouveauNom;
        }
    }
}
