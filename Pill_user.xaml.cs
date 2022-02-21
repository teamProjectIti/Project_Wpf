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
            list_pil_user.Add(new Pill_userClass
            {
                ID_bill = ++counter,
                name_product = compoText.Text,
                Name_Caher = txt_casher.Text,
                date_Bill = dateTime,
                Email = txtEmail.Text,
                Descound = Convert.ToInt32(txtdescound.Text),
                Phone=txtphone.Text,
                price=int.Parse(txtprice.Text),
                Qountity=Convert.ToInt32(txtQountity.Text),
                Sum_Total=int.Parse(txtSum.Text)

            };
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
