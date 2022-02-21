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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {

        List<ClassLogin> loginList = new List<ClassLogin>();

        public login()
        {
            InitializeComponent();
        }
        void clear()
        {
            textName.Text = "";
            txtPassword.Password = "";
        }

        int counter = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textName.Text != "" && txtPassword.Password != "")
            {
                ClassLogin l = new ClassLogin(++counter, textName.Text, txtPassword.Password);
                loginList.Add(l);
                MainWindow window = new MainWindow();   
                window.Show();
                this.Close();  

                clear();

            }
            else
            {
                MessageBox.Show("plz insert vaild data");
            }
        }
    }
}
