using project_iti_wpf_market.Model;
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

namespace project_iti_wpf_market.Order
{
    /// <summary>
    /// Interaction logic for Pill_user.xaml
    /// </summary>
    public partial class Pill_user : Window
    {
        public Pill_user()
        {
            InitializeComponent();
            //MarketProduct p = new MarketProduct();
            //var a= p.getproduct().ToList();

           
            //compoText.ItemsSource =a;
        }

        int counter = 0;
        List<Pill_userClass> list_pil_user= new List<Pill_userClass>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Pill_userClass pill = new Pill_userClass(++counter,Convert.ToDouble(txtprice.Text),int.Parse(txtQountity.Text),Convert.ToDouble(txtSum),int.Parse(txtdescound.Text), txtDetails.Text, txt_casher.Text,txtnameUser.Text,txtEmail.Text,txtphone.Text, dateTime);
            datagridview.ItemsSource = null;
            datagridview.ItemsSource = list_pil_user.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Product> p = MarketProduct.instance.getproduct();
            foreach(Product product in p)
            {
                compoText.Items.Add(product.name);
            }
        }
    }
}
