using System;
using System.Collections.Generic;
using System.Data;
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

namespace Projet_IHM.FragmentDePage
{
    /// <summary>
    /// Logique d'interaction pour UC_PageAdmin.xaml
    /// </summary>
    public partial class UC_PageAdmin : UserControl
    {
        public Manager Manager = (App.Current as App).LeManager;

        public Navigator Navigator => (App.Current as App).Navigator;

        public Array enumOptionnel
        {
            get { return Enum.GetValues(typeof(TypeDeComposantOptionnel)); }
        }

        public Array enumPrincipale
        {
            get { return Enum.GetValues(typeof(TypeDeComposantPrincipale)); }
        }

        public UC_PageAdmin()
        {
            InitializeComponent();
            DataContext = Manager;
        }

        public void test()
        {
            designation_txt.Text = "romain";
        }

        private void CheckBox_optionnel(object sender, RoutedEventArgs e)
        {
            Manager.MyEnumArray = enumOptionnel;
        }

        private void CheckBox_principale(object sender, RoutedEventArgs e)
        {
            Manager.MyEnumArray = enumPrincipale;
        }

        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.WIN_MAIN_WINDOW);
        }

        private void ComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string typeDecomposant = e.AddedItems[0].ToString();
            TypeDeComposantPrincipale type = 0;
            TypeDeComposantOptionnel typeOptionnel = 0;

            foreach (string nom in Enum.GetNames(typeof(TypeDeComposantPrincipale)))
            {
                if (nom == typeDecomposant)
                {
                    type = (TypeDeComposantPrincipale)Enum.Parse(typeof(TypeDeComposantPrincipale), nom);
                    break;
                }
            }


            Console.WriteLine(type);

            Dictionary<Caracteristique, string> dicoTemporel = new Dictionary<Caracteristique, string>();


            if (type != TypeDeComposantPrincipale.Inconnu)
            {
                switch (type)
                {
                    case TypeDeComposantPrincipale.Alimentation:
                        Manager.Dicocarac.Clear();
                        dicoTemporel.Clear();

                        dicoTemporel.Add(Caracteristique.Capacite, "0");
                        Manager.Dicocarac = dicoTemporel;

                        break;
                    case TypeDeComposantPrincipale.Carte_graphique:
                        Manager.Dicocarac.Clear();
                        dicoTemporel.Clear();

                        dicoTemporel.Add(Caracteristique.Frequence, "romain le bg");
                        dicoTemporel.Add(Caracteristique.NbCoeur, "0");
                        dicoTemporel.Add(Caracteristique.Slots, "0");
                        dicoTemporel.Add(Caracteristique.Consommation, "0"); 
                        Manager.Dicocarac = dicoTemporel;



                        break;
                    case TypeDeComposantPrincipale.Carte_mere:
                        Manager.Dicocarac.Clear();
                        Manager.Dicocarac.Add(Caracteristique.Frequence, "0");
                        Manager.Dicocarac.Add(Caracteristique.NbCoeur, "0");
                        Manager.Dicocarac.Add(Caracteristique.Socket, "0");
                        Manager.Dicocarac.Add(Caracteristique.TypeDeMemoire, "0");
                        Manager.Dicocarac.Add(Caracteristique.Slots, "0");
                        Manager.Dicocarac.Add(Caracteristique.Format, "0");
                        Manager.Dicocarac.Add(Caracteristique.Consommation, "0");

                        break;
                }
            }

            

        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string caracteristiqueValue = (sender as TextBox).Text;

            var test = (sender as DataGrid);


        }

        private void DataGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            DataGrid grid = sender as DataGrid;
            if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
            {
                //This is the code which helps to show the data when the row is double clicked.
                DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                KeyValuePair<Caracteristique, string> dr = (KeyValuePair<Caracteristique, string>)dgr.Item;

                //Manager.Nom = dr.Key.ToString();

                Manager.CaracteristiqueSelectionne = dr;
            }


            /*
            private void myDataGrid_selectionChanged(object sender, SelectionChangedEventArgs e)
            {
                DataGrid gd = (DataGrid)sender;
                DataRowView row_selected = gd.SelectedItem as DataRowView;

                if(row_selected != null)
                {
                    caracValeur_txt.Text = row_selected.ToString();
                }
            }

            private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
            {

            }
            */
        }

        public void remplir()
        {
            DataTable dt = new DataTable();
            DataColumn valeurCarac = new DataColumn("valeurCarac", typeof(string));

            dt.Columns.Add(valeurCarac);

            DataRow firstRow = dt.NewRow();
            firstRow[0] = "flot";

            dt.Rows.Add(firstRow);

            ///myDataGrid.ItemsSource = dt.DefaultView;
        }

        private void TextBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            

            string nouvelleValeur = (sender as TextBox).Text;

            Manager.Nom = nouvelleValeur;
        }

        public string Str
        {
            get { return (string)GetValue(StrProperty); }
            set { SetValue(StrProperty, value); }
        } 
        public static readonly DependencyProperty StrProperty =
                        DependencyProperty.Register("Str", typeof(string), typeof(UC_PageAdmin), new PropertyMetadata());



        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            Manager.Nom = Str;




            int nbligne = dataGrid_romain.Items.Count;

            for (int i = 0; i < nbligne; i++)
            {
                dataGrid_romain.Columns[0].GetCellContent().
            }

        }


    }
}
