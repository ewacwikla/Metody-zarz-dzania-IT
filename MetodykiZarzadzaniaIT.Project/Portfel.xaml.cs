using System;
using System.Collections.Generic;
using System.IO;
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
            var randVal = (RandomCoinValue.ThirdCoin()) + " $";
            firstValue.Content = (RandomCoinValue.ThirdCoin() * 8) + " $";
            secoundValue.Content = (RandomCoinValue.ThirdCoin() * 7) + " $";
            thirdValue.Content = MyExtensions.ToString(RandomCoinValue.FirstCoin()) + " $";
            fourValue.Content = MyExtensions.ToString(RandomCoinValue.SecondCoin()) + " $";

            CountBtc.Content = long.Parse(firstValue.Content.ToString().Remove(firstValue.Content.ToString().Length - 1)) * 0.03234;
            CountEth.Content = long.Parse(secoundValue.Content.ToString().Remove(secoundValue.Content.ToString().Length - 1)) * 0.421;
            CountNextCoin.Content = long.Parse(fourValue.Content.ToString().Remove(fourValue.Content.ToString().Length - 1)) * 33321.891;
            CountUECoint.Content = long.Parse(thirdValue.Content.ToString().Remove(thirdValue.Content.ToString().Length - 1)) * 1.65433;
        }

        private void OnLoad()
        {
            var randVal = (RandomCoinValue.ThirdCoin()).ToString() + " $";
            firstValue.Content = (RandomCoinValue.ThirdCoin() * 8).ToString() + " $";
            secoundValue.Content = (RandomCoinValue.ThirdCoin() * 7).ToString() + " $";
            thirdValue.Content = MyExtensions.ToString(RandomCoinValue.FirstCoin()) + " $";
            fourValue.Content = MyExtensions.ToString(RandomCoinValue.SecondCoin()) + " $";

            CountBtc.Content = long.Parse(firstValue.Content.ToString().Remove(firstValue.Content.ToString().Length -1)) * 0.03234;
            CountEth.Content = long.Parse(secoundValue.Content.ToString().Remove(secoundValue.Content.ToString().Length - 1)) * 0.421;
            CountNextCoin.Content = long.Parse(fourValue.Content.ToString().Remove(fourValue.Content.ToString().Length - 1)) * 33321.891;
            CountUECoint.Content = long.Parse(thirdValue.Content.ToString().Remove(thirdValue.Content.ToString().Length - 1)) * 1.65433;
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
