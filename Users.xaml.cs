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
            }
            else
             {
                MessageBox.Show("plz insert vaild data");
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        int id = 0;
        private void dvg_users_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var d = dvg_users.SelectedItem;
            id = int.Parse((dvg_users.SelectedCells[0].Column.GetCellContent(d) as TextBlock).Text);
            string name = (dvg_users.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            string description = (dvg_users.SelectedCells[2].Column.GetCellContent(d) as TextBlock).Text;
            Name_txt.Text = name;
            Email_txt.Text = description;
        }

        private void dvg_users_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //var d = dvg_users.SelectedItem;
            //id = int.Parse((dvg_users.SelectedCells[0].Column.GetCellContent(d) as TextBlock).Text);
            //string name = (dvg_users.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            //string description = (dvg_users.SelectedCells[2].Column.GetCellContent(d) as TextBlock).Text;
            //Name_txt.Text = name;
            //Email_txt.Text = description;

        }

        private void dvg_users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var d = dvg_users.SelectedItem;
            id = int.Parse((dvg_users.SelectedCells[0].Column.GetCellContent(d) as TextBlock).Text);
            string name = (dvg_users.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            string description = (dvg_users.SelectedCells[2].Column.GetCellContent(d) as TextBlock).Text;
            Name_txt.Text = name;
            Email_txt.Text = description;
        }
    }

}
