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
    /// Interaction logic for MarketProduct.xaml
    /// </summary>
    public partial class MarketProduct : Window
    {
        List<Product> products = new List<Product>();
        public static MarketProduct instance;
        int counter = 0;
        public MarketProduct()
        {
            InitializeComponent();
            instance = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.id = ++counter;
            product.name = pname.Text;
            product.quantity = 0;
            product.price = Convert.ToInt32(price.Text);
            product.categoray = pcatog.SelectedItem.ToString();
            product.ExpiredDate = pdate.SelectedDate.Value;
            product.store = pstore.SelectedItem.ToString();

            products.Add(product);
            grid.Items.Add(product);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Product p = grid.SelectedItem as Product;



            if (grid.SelectedIndex >= 0)

            {
                for (int i = 0; i <= grid.SelectedItems.Count; i++)
                {
                    grid.Items.Remove(grid.SelectedItems[i]);
                };
            }
            for (int i = 0; i < products.Count; i++)

            {
                if (products[i].id == p.id)

                {
                    products.Remove(products[i]);

                }
            }
        }
        public List<Product> getproduct()
        {
            return products;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grid.Items.Clear();


            foreach (Product product in products)
            {
                grid.Items.Add(product);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Order.Pill_spuliers bill = new Order.Pill_spuliers();
            bill.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Category> list = Window1.instance2.fillcategory();
            List<store> list2 = Window2.instance.fillstore();
            foreach (Category c in list)
            {
                pcatog.Items.Add(c.Name);
            }
            foreach(store s in list2)
            {
                pstore.Items.Add(s.Name);
            }

        }
    }
}
