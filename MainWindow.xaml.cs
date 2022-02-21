using project_iti_wpf_market.Order;
using project_iti_wpf_market.security;
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

namespace project_iti_wpf_market
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 f = new Window1();
            f.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MarketProduct f = new MarketProduct();
            f.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Users f = new Users();
            f.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            supplier f = new supplier();
            f.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window2 f = new Window2();
            f.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Pill_spuliers ss = new Pill_spuliers();
            ss.ShowDialog();


          
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Pill_user s = new Pill_user();
            s.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }
    }
}
