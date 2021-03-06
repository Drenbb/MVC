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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CMBfam.ItemsSource = Model.fam;
            Model.tbN = TXTshelk;
            Model.tbList = TXTfam;
        }

        private void BTNshelk_Click(object sender, RoutedEventArgs e)
        {
            Model.N++;
        }

        private void CMBfam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Model.Ind = comboBox.SelectedIndex;
        }
    }
}
