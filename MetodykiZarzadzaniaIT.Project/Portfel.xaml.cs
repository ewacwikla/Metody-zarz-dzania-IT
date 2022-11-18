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

namespace MetodykiZarzadzaniaIT.Project
{
    /// <summary>
    /// Interaction logic for Portfel.xaml
    /// </summary>
    public partial class Portfel : Window
    {
        public Portfel()
        {
            InitializeComponent();
            OnLoad();
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            var randVal = (RandomCoinValue.ThirdCoin()).ToString() + " $";
            firstValue.Content = (RandomCoinValue.ThirdCoin() * 8).ToString() + " $";
            secoundValue.Content = (RandomCoinValue.ThirdCoin() * 7).ToString() + " $";
            thirdValue.Content = MyExtensions.ToString(RandomCoinValue.FirstCoin()) + " $";
            fourValue.Content = MyExtensions.ToString(RandomCoinValue.SecondCoin()) + " $";
        }

        private void OnLoad()
        {
            var randVal = (RandomCoinValue.ThirdCoin()).ToString() + " $";
            firstValue.Content = (RandomCoinValue.ThirdCoin() * 8).ToString() + " $";
            secoundValue.Content = (RandomCoinValue.ThirdCoin() * 7).ToString() + " $";
            thirdValue.Content = MyExtensions.ToString(RandomCoinValue.FirstCoin()) + " $";
            fourValue.Content = MyExtensions.ToString(RandomCoinValue.SecondCoin()) + " $";
        }
        
    }

    public static class MyExtensions
    {
        public static string ToString(this object obj)
        {
            return obj.ToString();
        }
    }
}
