using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
    public partial class Start : Window
    {
        private QWERTY qwertyWindow;
        private AZERTY azertyWindow;

        private string error;
        private string azertynot;
        private string qwertynot;
        private string nokeyboardselected;

        //Ontvangen taal voor labels en knoppen
        public Start(string KeyboardLabelText, string ChooseLabelText, QWERTY qwerty, AZERTY azerty, string StartTestingText,
            string errorText, string azertynotText, string qwertynotText, string nokeyboardselectedText)
        {
            InitializeComponent();

            List<string> keyboards = new List<string> { "AZERTY", "QWERTY" };
            toestenbordcombobox.ItemsSource = keyboards;
            keyboardlbl.Content = KeyboardLabelText;
            kieslbl.Content = ChooseLabelText;
            startbtn.Content = StartTestingText;

            qwertyWindow = qwerty;
            azertyWindow = azerty;

            this.error = errorText;
            this.azertynot = azertynotText;
            this.qwertynot = qwertynotText;
            this.nokeyboardselected = nokeyboardselectedText;
        }

        //welk keyboard geselecteerd wordt
        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            if (toestenbordcombobox.SelectedItem != null)
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
                        MessageBox.Show($"{GetAzertyNotText()}", GetErrorText(), MessageBoxButton.OK, MessageBoxImage.Error);
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
                        MessageBox.Show($"{GetQwertyNotText()}", GetErrorText(), MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show($"{GetNoKeyboardSelectedText()}", GetErrorText(), MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
        }

        //talen aanpassingen messageboxen
        public string GetErrorText()
        {
            return error;
        }
        public string GetAzertyNotText()
        {
            return azertynot;
        }
        public string GetQwertyNotText()
        {
            return qwertynot;
        }
        public string GetNoKeyboardSelectedText()
        {
            return nokeyboardselected;
        }

    }
}