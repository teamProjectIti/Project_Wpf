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
    /// Interaction logic for Window2.xaml
    /// </summary>
    /// public static Form4 instance4;
    public partial class Window2 : Window
    {
        static List<store> stores = new List<store>();
        public Window2()
        {
            InitializeComponent();
        }
        int counter = 0;
        int id = 0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textname.Text == "" && textadd.Text == "" && textphone.Text == "")
                {
                    throw new Exception();
                }
                if (textname.Text == "")
                {

                    throw new Exception();
                }
                if (textadd.Text == "")
                {
                    throw new Exception();
                }
                store s = new store(textname.Text, textadd.Text, textphone.Text);
                stores.Add(s);
                datagrid.ItemsSource = null;
                datagrid.ItemsSource = stores;
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("you must Fill the Text Boxes before adding!");
            }

        }
        private void clear()
        {
            textname.Text = textadd.Text = textphone.Text = "";
        }

        public static List<store> fillstore()
        {

            return stores;
        }
        string name;
        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            datagrid.ItemsSource = stores;
            id = counter;

            var d = datagrid.SelectedItem;
            name = (datagrid.SelectedCells[0].Column.GetCellContent(d) as TextBlock).Text;
            string address = (datagrid.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            string phone = (datagrid.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            textname.Text = name;
            textadd.Text = address;
            textphone.Text = phone;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (textname.Text == "" && textadd.Text == "" && textphone.Text == "")
                {
                    throw new Exception();
                }
                if (textname.Text == "")
                {

                    throw new Exception();
                }
                if (textadd.Text == "")
                {
                    throw new Exception();
                }

                store result = stores.Find(x => x.Name == name);
                stores.Remove(result);
                store s = new store(textname.Text, textadd.Text, textphone.Text);
                stores.Add(s);
                datagrid.ItemsSource = null;
                datagrid.ItemsSource = stores;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you must Fill the Text Boxes before adding!");
            }



        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (textname.Text == "" && textadd.Text == "" && textphone.Text == "")
                {
                    throw new Exception();
                }
                if (textname.Text == "")
                {

                    throw new Exception();
                }
                if (textadd.Text == "")
                {
                    throw new Exception();
                }

                var result = stores.Find(x => x.Name == name);
                stores.Remove(result);
                datagrid.ItemsSource = null;
                datagrid.ItemsSource = stores;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you must Fill the Text Boxes before adding!");
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }
    }
}
