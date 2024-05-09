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
        private QWERTY qwertyWindow;
        private AZERTY azertyWindow;
        public Start(string KeyboardLabelText, string ChooseLabelText, QWERTY qwerty, AZERTY azerty)
        {
            InitializeComponent();

            List<string> keyboards = new List<string> { "AZERTY", "QWERTY" };
            toestenbordcombobox.ItemsSource = keyboards;
            keyboardlbl.Content = KeyboardLabelText;
            kieslbl.Content = ChooseLabelText;

            qwertyWindow = qwerty;
            azertyWindow = azerty;
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            if (toestenbordcombobox.SelectedItem.ToString() == "AZERTY")
            {
                if (azertyWindow != null)
                {
                    this.Visibility = Visibility.Hidden;
                    azertyWindow.Show();
                }
                else
                {
                    MessageBox.Show("AZERTY-venster is niet correct geïnitialiseerd.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (toestenbordcombobox.SelectedItem.ToString() == "QWERTY")
            {
                if (qwertyWindow != null)
                {
                    this.Visibility = Visibility.Hidden;
                    qwertyWindow.Show();
                }
                else
                {
                    MessageBox.Show("QWERTY-venster is niet correct geïnitialiseerd.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
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