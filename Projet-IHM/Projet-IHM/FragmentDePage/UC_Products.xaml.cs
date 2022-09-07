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




namespace Projet_IHM
{
    /// <summary>
    /// Logique d'interaction pour UC_Products.xaml
    /// </summary>
    public partial class UC_Products : UserControl
    {

        /// <summary>
        /// Récupération du Manager instancié dans l'application courante
        /// </summary>
        public Manager Mgr => (App.Current as App).LeManager;


        /// <summary>
        /// Récupération du Navigator instancié dans l'application courante
        /// </summary>
        public Navigator Navigator = (App.Current as App).Navigator;


        /// <summary>
        /// Stocke le type de composants demandé
        /// </summary>
        private TypeDeComposantPrincipale Type { get; set; }


        /// <summary>
        /// Contient tout les composants du type Type
        /// </summary>
        private List<Composant> listeComposantTmp;



        public UC_Products(TypeDeComposantPrincipale TypeCompo)
        {
            InitializeComponent();
            Mgr.Compatibilite(TypeCompo);
            Type = TypeCompo;

            // Initialisation de la liste
            listeComposantTmp = Mgr.CompoAffiche;


            // Vérification présence de composants pour éviter la possibilité d'ajouter un composants si il n'y en a aucun
            if(Mgr.CompoAffiche.Count() != 0)
            {
                Mgr.ComposantSelectionne = Mgr.CompoAffiche[0];
            }
            else
            {
                Ajouter.IsEnabled = false;
            }

            DataContext = Mgr;
        }



        public UC_Products()
        {
            InitializeComponent();
            Mgr.CompoAffiche.Clear();

            List<Composant> composantAfficheTmp = new List<Composant>();

            
            foreach (var compo in Mgr.ComposantOptionnel)
            {
                composantAfficheTmp.Add(compo);
            }

            // Chargement de la liste des composants à ajouter
            Mgr.CompoAffiche = composantAfficheTmp;
            Mgr.ComposantSelectionne = Mgr.CompoAffiche[0];
            DataContext = Mgr;
        }


        /// <summary>
        /// Ajouter le composants séléctionné à la wishlist courante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Mgr.ComposantSelectionne.GetType() == typeof(ComposantPrincipale))
            {
                Mgr.AddComposantPrincipal(Mgr.ComposantSelectionne as ComposantPrincipale);
            }
            else
            {
                Mgr.AddComposantOptionnel(Mgr.ComposantSelectionne as ComposantOptionnel);
            }

            // Retour à la page principale
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }




        /// <summary>
        /// Recherche dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = (sender as TextBox).Text;
            

            //Verification : si aucun text tappé on affiche tout les composant de Type
            if (recherche.Length == 0)
            {
                Mgr.CompoAffiche = listeComposantTmp;
                Mgr.ComposantSelectionne = Mgr.CompoAffiche[0];
                Ajouter.IsEnabled = true;
                MainTab.Visibility = Visibility.Visible;
                CaracText.Visibility = Visibility.Visible;

            }
            else
            {
                Mgr.Compatibilite(Type);

                List<Composant> ComposantAfficheTmp = new List<Composant>();
                 
                foreach (var obj in Mgr.CompoAffiche)
                {
                    if (obj.Designation.ToLower().Contains(recherche.ToLower()))
                    {
                        ComposantAfficheTmp.Add(obj);
                    }
                }

                //obligé de faire un = pour apppeller le settetr de CompoAffiche et envoyé notif de changement
                Mgr.CompoAffiche = ComposantAfficheTmp;


                // Vérification de la présence d'un composant dans la liste à afficher
                if(Mgr.CompoAffiche.Count != 0)
                {
                    Mgr.ComposantSelectionne = Mgr.CompoAffiche[0];
                    Ajouter.IsEnabled = true;
                    CaracText.Visibility = Visibility.Visible;
                    MainTab.Visibility = Visibility.Visible;

                }
                else
                {
                    Mgr.ComposantSelectionne = null;
                    Ajouter.IsEnabled = false;
                    CaracText.Visibility = Visibility.Hidden;
                    MainTab.Visibility = Visibility.Hidden;

                }


            }
        }


        /// <summary>
        /// Navigation vers la page principale après click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }
    }
}

