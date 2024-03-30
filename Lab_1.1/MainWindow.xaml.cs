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

namespace Lab_1._1
{
    public partial class MainWindow : Window
    {
        private TEREMOKEntities buyer = new TEREMOKEntities();
        public MainWindow()
        {
            InitializeComponent();
            TeremokGrid.ItemsSource = buyer.BUYERS.ToList(); 
        }
        private void Teremokgrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = TeremokGrid.SelectedItem as BUYERS;
            MessageBox.Show(selected.ID_BUYERS.ToString);
            MessageBox.Show(selected.ID_BLINI); 
        }
    }
}
