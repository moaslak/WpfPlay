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

namespace WpfPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (!(list.Contains(textbox.Text)) && textbox.Text != "")
            {
                list.Add(textbox.Text);
                listbox.Items.Clear();

                foreach (string item in list)
                    listbox.Items.Add(item);

                textbox.Text = "";
            }
            
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                int index = listbox.SelectedIndex;
                list.RemoveAt(index);
            }

            listbox.Items.Clear();

            foreach (string item in list)
                listbox.Items.Add(item);
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WinnerBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Winner(object sender, RoutedEventArgs e)
        {
            if (list.Count == 0)
                return;

            Random rand = new Random();
            int winner = rand.Next(0, list.Count);

            MessageBox.Show("The winner is: " + list[winner]);
        }
    }
}
