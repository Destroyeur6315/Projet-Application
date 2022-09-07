using Modele;
using Projet_IHM.FragmentDePage;
using Projet_IHM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Projet_IHM
{

    /// <summary>
    /// Classe qui va gérer la navigation entre les fenêtres de l'application
    /// </summary>
    public class Navigator : INotifyPropertyChanged
    {

        /// <summary>
        /// Constante désignant les différentes fenetre de l'appli
        /// </summary>
        public const string WIN_MAIN_WINDOW = "MainWindow";
        public const string WIN_PROCESSEUR = "ProductsProcesseur";
        public const string WIN_CARTE_MERE = "ProductsCarteMere";
        public const string WIN_BOITIER = "ProductsBoitier";
        public const string WIN_RAM = "ProductsRam";
        public const string WIN_ALIMENTATION = "ProductsAlimentation";
        public const string WIN_STOCKAGE = "ProductsStockage";
        public const string WIN_VENTIRAD = "ProductsVentirad";
        public const string WIN_CARTE_GRAPHIQUE = "ProductsCarteGraphique";
        public const string WIN_COMPO_OPTIONNEL = "ProductsCompoOptionnel";

        public const string WIN_GUIDE_INSTALLATION = "InstallationGuide";
        public const string WIN_PAGE_ADMIN = "PageAdmin";
        public const string WIN_PAGE_RENOMMAGE = "PageConfirmerRenommage";


        /// <summary>
        /// Dictionnaire associant une chaine de caractères à un Fragment de fenêtre UserControl
        /// </summary>
        public static Dictionary<string, Func<UserControl>> DicFenetres { get; private set; } = new Dictionary<string, Func<UserControl>>()
        {
            [WIN_MAIN_WINDOW] = () => new UC_MainWindow(),
            [WIN_PROCESSEUR] = () => new UC_Products(TypeDeComposantPrincipale.Processeur),
            [WIN_CARTE_MERE] = () => new UC_Products(TypeDeComposantPrincipale.Carte_mere),
            [WIN_BOITIER] = () => new UC_Products(TypeDeComposantPrincipale.Boitier),
            [WIN_RAM] = () => new UC_Products(TypeDeComposantPrincipale.Memoire_vive),
            [WIN_ALIMENTATION] = () => new UC_Products(TypeDeComposantPrincipale.Alimentation),
            [WIN_STOCKAGE] = () => new UC_Products(TypeDeComposantPrincipale.Stockage),
            [WIN_VENTIRAD] = () => new UC_Products(TypeDeComposantPrincipale.Ventirad),
            [WIN_CARTE_GRAPHIQUE] = () => new UC_Products(TypeDeComposantPrincipale.Carte_graphique),
            [WIN_PAGE_ADMIN] = () => new UC_PageAdmin(),
            [WIN_GUIDE_INSTALLATION] = () => new UC_GuideInstallation(),
            [WIN_PAGE_RENOMMAGE] = () => new UC_ConfirmerRenommage(),
            [WIN_COMPO_OPTIONNEL] = () => new UC_Products(),
        };


        /// <summary>
        /// Constructeur de la classe navigator
        /// </summary>
        public Navigator()
        {
            UserControlCourant = DicFenetres.First();
        }


        /// <summary>
        /// Propriété qui désigne l'userControl qui est adffiché a l'écran
        /// </summary>
        public KeyValuePair<string, Func<UserControl>> UserControlCourant
        {
            get => userControlCourant;
            set
            {
                if (userControlCourant.Equals(value)) return;
                userControlCourant = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Désigne l'userControl qui est adffiché a l'écran
        /// </summary>
        private KeyValuePair<string, Func<UserControl>> userControlCourant;


        /// <summary>
        /// Evenement qui sera invoqué lorsque l'utilisateur changera de fenêtres
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fonction qui invoque l'évènement
        /// </summary>
        /// <param name="propertyName"></param>
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



        /// <summary>
        /// Fonction qu ipermet de changer de fragment de page
        /// </summary>
        /// <param name="windowPartName"></param>
        public void NavigateTo(string windowPartName)
        {
            if (DicFenetres.ContainsKey(windowPartName))
            {
                UserControlCourant = DicFenetres.Single(kvp => kvp.Key == windowPartName);
            }
        }
    }
}

