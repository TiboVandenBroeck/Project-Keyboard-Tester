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
            string greenMessage = nederlands.GreenMessage();
            string grayMessage = nederlands.GrayMessage();
            string jsonsaveMessage = nederlands.JsonSaveTxtMessage();
            string jsonsearchMessage = nederlands.JsonSearchTxtMessage();
            string jsonsavebtnMessage = nederlands.JsonSaveBtnTxtMessage();
            string jsonsearchbtnMessage = nederlands.JsonSearchBtnTxtMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty , azerty);
            start.Show();
            this.Hide();
        }

        private void FransButton_Click(object sender, RoutedEventArgs e)
        {
            Frans frans = new Frans();
            string headerMessage = frans.HeaderMessage();
            string chooseMessage = frans.ChooseMessage();
            string greenMessage = frans.GreenMessage();
            string grayMessage = frans.GrayMessage();
            string jsonsaveMessage = frans.JsonSaveTxtMessage();
            string jsonsearchMessage = frans.JsonSearchTxtMessage();
            string jsonsavebtnMessage = frans.JsonSaveBtnTxtMessage();
            string jsonsearchbtnMessage = frans.JsonSearchBtnTxtMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty, azerty);
            start.Show();
            this.Hide();
        }

        private void SpaansButton_Click(object sender, RoutedEventArgs e)
        {
            Spaans spaans = new Spaans();
            string headerMessage = spaans.HeaderMessage();
            string chooseMessage = spaans.ChooseMessage();
            string greenMessage = spaans.GreenMessage();
            string grayMessage = spaans.GrayMessage();
            string jsonsaveMessage = spaans.JsonSaveTxtMessage();
            string jsonsearchMessage = spaans.JsonSearchTxtMessage();
            string jsonsavebtnMessage = spaans.JsonSaveBtnTxtMessage();
            string jsonsearchbtnMessage = spaans.JsonSearchBtnTxtMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, jsonsavebtnMessage, jsonsearchbtnMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty, azerty);
            start.Show();
            this.Hide();
        }
    }
}
