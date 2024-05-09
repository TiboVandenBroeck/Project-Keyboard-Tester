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
        public Start(string KeyboardLabelText, string ChooseLabelText)
        {
            InitializeComponent();

            List<string> keyboards = new List<string> { "AZERTY", "QWERTY" };
            toestenbordcombobox.ItemsSource = keyboards;
            keyboardlbl.Content = KeyboardLabelText;
            kieslbl.Content = ChooseLabelText;
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
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