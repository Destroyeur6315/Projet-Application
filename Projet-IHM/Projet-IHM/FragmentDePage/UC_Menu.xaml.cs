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
    /// Logique d'interaction pour UC_Menu.xaml
    /// </summary>
    public partial class UC_Menu : UserControl
    {
        /// <summary>
        /// Manager instancié dans l'application courante
        /// </summary>
        Manager manager = (App.Current as App).LeManager;


        /// <summary>
        /// Navigator instancié dans l'application courante
        /// </summary>
        public Navigator Navigator => (App.Current as App).Navigator;

        public UC_Menu()
        {
            InitializeComponent();
            DataContext = manager;
            //BtnAdmin.IsEnabled = false;
        }


        /// <summary>
        /// Redirection sur la page admin après click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageAdmin_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_PAGE_ADMIN);
        }


        /// <summary>
        /// Redirection sur la page Guide d'installation après click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuideInstallation_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_GUIDE_INSTALLATION);
        }


        /// <summary>
        /// Redirection sur la page principale après click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }
    }
}
