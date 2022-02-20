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

namespace project_iti_wpf_market
{
    /// <summary>
    /// Interaction logic for supplier.xaml
    /// </summary>
    public partial class supplier : Window
    {
        List<Seller> sellers = new List<Seller>();
        int counter = 0;
        public supplier()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Seller seller = new Seller();


            seller.id = ++counter;
            seller.Name = sname.Text;
            seller.address = saddre.Text;
            seller.Email = semail.Text;
            seller.phone = sphone.Text;
            seller.store_name = store.SelectedItem.ToString();


            sellers.Add(seller);
            grid.Items.Add(seller);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Seller s = grid.SelectedItem as Seller;



            if (grid.SelectedIndex >= 0)

            {
                for (int i = 0; i <= grid.SelectedItems.Count; i++)
                {
                    grid.Items.Remove(grid.SelectedItems[i]);
                };
            }
            for (int i = 0; i < sellers.Count; i++)

            {
                if (sellers[i].id == s.id)

                {
                    sellers.Remove(sellers[i]);

                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<store> list=Window2.instance.fillstore();
            foreach(store s in list)
            {
                store.Items.Add(s.Name);
            }
        }
    }
}
