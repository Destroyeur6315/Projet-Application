using System;
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
using System.Collections.Generic;
using Modele;
using System.Windows.Threading;

namespace Projet_IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public Navigator Navigator => (App.Current as App).Navigator;

        public Manager Mgr => (App.Current as App).LeManager;

        DispatcherTimer timer;

        double panelWidth;
        bool IsHidden;



        public MainWindow()
        {
            InitializeComponent();
            CC_Menu.Content = new UC_Menu();
            CC_Menu.Width = 0;
            DataContext = this;
            IsHidden = true;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;

            panelWidth = 350;
        }




        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsHidden)
            {
                CC_Menu.Width += 20;
                if (CC_Menu.Width >= panelWidth)
                {
                    timer.Stop();
                    IsHidden = false;
                }
            }
            else
            {
                CC_Menu.Width -= 20;
                if (CC_Menu.Width <= 0)
                {
                    timer.Stop();
                    IsHidden = true;
                }
            }
        }

        private void Show_Menu(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
