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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public static Window1 instance2;
        // static List<Category> list = new List<Category>();
        public static List<Category> categories = new List<Category>();

        int counter = 0;
        int id = 0;
        public Window1()
        {
            InitializeComponent();
            instance2 = this;
        }

        public  List<Category> fillcategory()
        {

            return categories;
        }
        private void McDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            McDataGrid.ItemsSource = categories;
            id = counter;

            var d = McDataGrid.SelectedItem;
            string name = (McDataGrid.SelectedCells[1].Column.GetCellContent(d) as TextBlock).Text;
            string description = (McDataGrid.SelectedCells[2].Column.GetCellContent(d) as TextBlock).Text;
            TextBox1.Text = name;
            TextBox2.Text = description;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            McDataGrid.ItemsSource = categories.ToList();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            supplier s = new supplier();
            s.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MarketProduct m = new MarketProduct();
            m.Show();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TextBox1.Text == "" && TextBox2.Text == "")
                {
                    MessageBox.Show("you must fill text boxes!");
                }
                else if (TextBox1.Text == "")
                {

                    MessageBox.Show("you must fill text boxes!");
                }
                else if (TextBox2.Text == "")
                {
                    MessageBox.Show("you must fill text boxes!");
                }

                Category result = categories.Find(x => x.ID == id);
                categories.Remove(result);
                Category c = new Category(id, TextBox1.Text, TextBox2.Text);
                categories.Add(c);
                McDataGrid.ItemsSource = null;
                McDataGrid.ItemsSource = categories;
                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("edited successfully!");
            }
        }

        private void clear()
        {
            TextBox1.Text = TextBox2.Text = "";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TextBox1.Text == "" && TextBox2.Text == "")
                {
                    throw new Exception();
                }
                if (TextBox1.Text == "")
                {

                    throw new Exception();
                }
                if (TextBox2.Text == "")
                {
                    throw new Exception();
                }
                Category c = new Category(++counter, TextBox1.Text, TextBox2.Text);
                categories.Add(c);
                McDataGrid.ItemsSource = null;
                McDataGrid.ItemsSource = categories;
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
                if (TextBox1.Text == "" && TextBox2.Text == "")
                {
                    MessageBox.Show("you must fill text boxes!");

                }
                else if (TextBox1.Text == "")
                {

                    MessageBox.Show("you must fill text boxes!");
                }
                else if (TextBox2.Text == "")
                {
                    MessageBox.Show("you must fill text boxes!");
                }
                var result = categories.Find(x => x.ID == id);
                categories.Remove(result);
                McDataGrid.ItemsSource = null;
                McDataGrid.ItemsSource = categories;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("removed successfully ");
            }

        }
    }
}
