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
    /// Logique d'interaction pour UC_MainWindow.xaml
    /// </summary>
    public partial class UC_MainWindow : UserControl
    {

        /// <summary>
        /// Manager instancié dans l'application courante
        /// </summary>
        public Manager Manager = (App.Current as App).LeManager;


        /// <summary>
        /// Navigator instancié dans l'application courante
        /// </summary>
        public Navigator Navigator => (App.Current as App).Navigator;


        public UC_MainWindow()
        {
            InitializeComponent();
            DataContext = Manager;
        }



        /// <summary>
        /// Afficher le détail pour les processeurs si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Processeur(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Processeur))
            {
                Navigator.NavigateTo(Navigator.WIN_PROCESSEUR);
            }
        }


        /// <summary>
        /// Afficher le détail pour les cartes mères si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Carte_Mere(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Carte_mere))
            {
                Navigator.NavigateTo(Navigator.WIN_CARTE_MERE);
            }
        }


        /// <summary>
        /// Afficher le détail pour les alimentations si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Alimentation(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Alimentation))
            {
                Navigator.NavigateTo(Navigator.WIN_ALIMENTATION);
            }
        }



        /// <summary>
        /// Afficher le détail pour les RAM si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_RAM(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Memoire_vive))
            {
                Navigator.NavigateTo(Navigator.WIN_RAM);
            }
        }


        /// <summary>
        /// Afficher le détail pour les boitiers si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Boitier(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Boitier))
            {
                Navigator.NavigateTo(Navigator.WIN_BOITIER);
            }
        }



        /// <summary>
        /// Afficher le détail pour les stockages si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Stockage(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Stockage))
            {
                Navigator.NavigateTo(Navigator.WIN_STOCKAGE);
            }
        }



        /// <summary>
        /// Afficher le détail pour les ventirad si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Ventirad(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Ventirad))
            {
                Navigator.NavigateTo(Navigator.WIN_VENTIRAD);
            }
        }



        /// <summary>
        /// Afficher le détail pour les cartes Graphiques si click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Carte_Graphique(object sender, RoutedEventArgs e)
        {
            if (! Manager.verifComposantExistant(TypeDeComposantPrincipale.Carte_graphique))
            {
                Navigator.NavigateTo(Navigator.WIN_CARTE_GRAPHIQUE);
            }
        }


        /// <summary>
        /// Ajout de la wishlist courante aux favoris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.AddUneListeAuxFavoris();
        }



        /// <summary>
        /// Afficher le détail pour les composants optionnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Composant_Optionnel(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_COMPO_OPTIONNEL);
        }
    
    
    
    }
}
