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

namespace Project_Keyboard_Tester
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();

            List<string> talen = new List<string> { "Nederlands", "Frans", "Spaans" };
            taalcombobox.ItemsSource = talen;

            List<string> keyboards = new List<string> { "AZERTY", "QWERTY" };
            toestenbordcombobox.ItemsSource = keyboards;
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            if (taalcombobox.SelectedItem == null || toestenbordcombobox.SelectedItem == null)
            {
                MessageBox.Show("Selecteer alstublieft een taal en een toetsenbord.", "Fout", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (toestenbordcombobox.SelectedItem.ToString() == "AZERTY")
            {
                AZERTY azertywindow = new AZERTY();
                this.Visibility = Visibility.Hidden;
                azertywindow.Show();
            }
            else if (toestenbordcombobox.SelectedItem.ToString() == "QWERTY")
            {
                QWERTY qwertywindow = new QWERTY();
                this.Visibility = Visibility.Hidden;
                qwertywindow.Show();
            }
            else
            {
                MessageBox.Show("Ongeldige toetsenbordoptie geselecteerd.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            

            this.Close();

            

        }
    }
}
