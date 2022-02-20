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

namespace project_iti_wpf_market.security
{
    /// <summary>
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : Window
    {
          List<ClassUsers> UsersList = new List<ClassUsers>();
            public Users()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void Btn_insert(object sender, RoutedEventArgs e)
        {
            if(Name_txt.Text != "" && Email_txt.Text != "" && phone_txt.Text != "" && address_txt.Text != "")
            {
                ClassUsers c = new ClassUsers(++counter, Name_txt.Text, Email_txt.Text, phone_txt.Text, address_txt.Text);
                UsersList.Add(c);
                dvg_users.ItemsSource = null;
                dvg_users.ItemsSource = UsersList;
                clear();

            }
            else
             {
                MessageBox.Show("plz insert vaild data");
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            var list = UsersList.Where(x=>x.ID==id).FirstOrDefault();
            list.Name= Name_txt.Text;
            list.address = address_txt.Text;
            list.phone=phone_txt.Text;
            list.email=Email_txt.Text;
            dvg_users.ItemsSource = null;
            dvg_users.ItemsSource = UsersList;
            clear();

        }
        int id = 0;
        private void dvg_users_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ClassUsers d = (ClassUsers)dvg_users.SelectedItem;
            id = d.ID;
            Name_txt.Text = d.Name;
            address_txt.Text = d.address;
            phone_txt.Text = d.phone;
            Email_txt.Text = d.email;
        }

        private void dvg_users_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
        }

        private void dvg_users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            var list = UsersList.Where(x => x.ID == id).FirstOrDefault();
            UsersList.Remove(list);
            dvg_users.ItemsSource = null;
            dvg_users.ItemsSource = UsersList;
            clear();
        }
        void clear()
        {
            id_txt.Text =Name_txt.Text = address_txt.Text = Email_txt.Text = phone_txt.Text = "";
        }

        private void ClearRowBtn_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
    }

}
