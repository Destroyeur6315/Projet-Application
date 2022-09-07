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
using Modele;

namespace Projet_IHM.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UC_Favoris.xaml
    /// </summary>
    public partial class UC_Favoris : UserControl
    {

        /// <summary>
        /// Récupération du Manager instancié dans l'application courante
        /// </summary>
        public Manager manager = (App.Current as App).LeManager;


        /// <summary>
        /// Récupération du Navigator instancié dans l'application courante
        /// </summary>
        public Navigator Navigator => (App.Current as App).Navigator;

        public UC_Favoris()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Propriété récupérant une wishlist bindée
        /// </summary>
        public WishList WishlistFav
        {
            get { return (WishList)GetValue(WishListFavProperty); }
            set { SetValue(WishListFavProperty, value); }
        }

        public static readonly DependencyProperty WishListFavProperty =
            DependencyProperty.Register("WishlistFav", typeof(WishList), typeof(UC_Favoris), new PropertyMetadata(new WishList()));



        /// <summary>
        /// Supprime une wishlist des favoris au click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suppFavoris_Click(object sender, RoutedEventArgs e)
        {
            manager.DeleteUneListeDesFavoris(WishlistFav.Nom);

        }

        /// <summary>
        /// Valide le changement de nom au click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierNom_Click(object sender, RoutedEventArgs e)
        {
            manager.NomWishlistAmodifier = WishlistFav.Nom;

            Navigator.NavigateTo(Navigator.WIN_PAGE_RENOMMAGE);

        }


        /// <summary>
        /// Ouvre la wishlist clické dans la wishList courante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierListe_Click(object sender, RoutedEventArgs e)
        {
            manager.ModifierUnelisteDesfavoris(WishlistFav.Nom);
        }


        /// <summary>
        /// Changement de la couleur de l'image au survole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseEnter_Supp(object sender, MouseEventArgs e)
        {
            ImageSupp.Source = new BitmapImage(new Uri("../Img/ImgLogo/CroixBleue.png", UriKind.RelativeOrAbsolute));
        }
        private void Button_MouseLeave_Supp(object sender, MouseEventArgs e)
        {
            ImageSupp.Source = new BitmapImage(new Uri("../Img/ImgLogo/CroixBlanc.png", UriKind.RelativeOrAbsolute));
        }



        /// <summary>
        /// Changement de la couleur de l'image au survole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseEnter_Rename(object sender, MouseEventArgs e)
        {
            ImageRename.Source = new BitmapImage(new Uri("../Img/ImgLogo/CrayonBleu.png", UriKind.RelativeOrAbsolute));

        }
        private void Button_MouseLeave_Rename(object sender, MouseEventArgs e)
        {
            ImageRename.Source = new BitmapImage(new Uri("../Img/ImgLogo/CrayonBlanc.png", UriKind.RelativeOrAbsolute));

        }


        /// <summary>
        /// Changement de la couleur de l'image au survole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseEnter_Modif(object sender, MouseEventArgs e)
        {
            ImageModif.Source = new BitmapImage(new Uri("../Img/ImgLogo/ModifBleu.png", UriKind.RelativeOrAbsolute));
        }
        private void Button_MouseLeave_Modif(object sender, MouseEventArgs e)
        {
            ImageModif.Source = new BitmapImage(new Uri("../Img/ImgLogo/ModifBlanc.png", UriKind.RelativeOrAbsolute));
        }

    }
}

