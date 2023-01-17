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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace MetodykiZarzadzaniaIT.Project
{
    /// <summary>
    /// Interaction logic for Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
            KryptoZListy.SelectedItem = KryptoZListy.Items[0];
        }

        private decimal ActualPrice = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ActualPrice == 1)
            {
                ActualPrice = RandomCoinValue.ThirdCoin();
            }

            Wynik.Content = decimal.Parse(IloscDoWpisania.Text) * ActualPrice;
        }

        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
             e.Handled = regex.IsMatch(e.Text);
        }
    }
}
