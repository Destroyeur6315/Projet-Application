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

namespace Projet_IHM
{
    /// <summary>
    /// Logique d'interaction pour MyUC_Composant.xaml
    /// </summary>
    public partial class MyUC_Composant : UserControl
    {
        public MyUC_Composant()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Evenement appellé lors du click sur un composant
        /// </summary>
        public event EventHandler<RoutedEventArgs> ClickChangeProductPageEnvent;


        /// <summary>
        /// Click sur le boiuton permet d'envoyer une notification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ClickChangeProductPageEnvent?.Invoke(this, e);
        }



        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(string), typeof(MyUC_Composant), new PropertyMetadata("../Img/Default.png"));



        /// <summary>
        /// Agrandissemnt de l'image lors d'un survolement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnComposant.Margin = new Thickness(40);
            ImageXAML.Width += 20;
            ImageXAML.Height += 20;
        }


        /// <summary>
        /// Rétrécissement de l'image lorsqu'on ne survole plus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnComposant.Margin = new Thickness(50);
            ImageXAML.Width -= 20;
            ImageXAML.Height -= 20;
        }
    }
}
