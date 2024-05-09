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

namespace Project_Keyboard_Tester
{
    /// <summary>
    /// Interaction logic for taalselect.xaml
    /// </summary>
    public partial class taalselect : Window
    {
        public taalselect()
        {
            InitializeComponent();
        }


        private void NederlandsButton_Click(object sender, EventArgs e)
        {
            Nederlands nederlands = new Nederlands();
            string headerMessage = nederlands.HeaderMessage();
            string chooseMessage = nederlands.ChooseMessage();

            Start start = new Start(headerMessage, chooseMessage);
            start.Show();
            this.Hide();
        }

        private void FransButton_Click(object sender, RoutedEventArgs e)
        {
            Frans frans = new Frans();
            string headerMessage = frans.HeaderMessage();
            string chooseMessage = frans.ChooseMessage();

            Start start = new Start(headerMessage, chooseMessage);
            start.Show();
            this.Hide();
        }

        private void SpaansButton_Click(object sender, RoutedEventArgs e)
        {
            Spaans spaans = new Spaans();
            string headerMessage = spaans.HeaderMessage();
            string chooseMessage = spaans.ChooseMessage();

            Start start = new Start(headerMessage, chooseMessage);
            start.Show();
            this.Hide();
        }
    }
}
