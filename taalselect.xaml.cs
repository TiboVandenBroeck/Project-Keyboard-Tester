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

        //Als knop ingedrukt wordt, wordt de juiste taal doorgestuurd naar de nodige items
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
            string starttestingbtnMessage = nederlands.StartTestingBtnTxtMessage();
            string succesvolopgeslagenMessage = nederlands.OpslaanMessage();
            string voltooidMessage = nederlands.VoltooidMessage();
            string filedoesntexistMessage = nederlands.FileDoesntExistMessage();
            string filenotfoundMessage = nederlands.FileNotFoundMesssage();
            string rectanglemarkedMessage = nederlands.RectanglesMarkedMessage();
            string completedMessage = nederlands.CompletedMessage();
            string foutMessage = nederlands.ErrorMessage();
            string azertynotMessage = nederlands.AzertyNotMessage();
            string qwertynotMessage = nederlands.QwertyNotMessage();
            string nokeyboardselectedMessage = nederlands.NoKeyboardSelectedMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, 
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage, 
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage, 
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage, 
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty , azerty, starttestingbtnMessage,
                foutMessage, azertynotMessage, qwertynotMessage, nokeyboardselectedMessage);
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
            string starttestingbtnMessage = frans.StartTestingBtnTxtMessage();
            string succesvolopgeslagenMessage = frans.OpslaanMessage();
            string voltooidMessage = frans.VoltooidMessage();
            string filedoesntexistMessage = frans.FileDoesntExistMessage();
            string filenotfoundMessage = frans.FileNotFoundMesssage();
            string rectanglemarkedMessage = frans.RectanglesMarkedMessage();
            string completedMessage = frans.CompletedMessage();
            string foutMessage = frans.ErrorMessage();
            string azertynotMessage = frans.AzertyNotMessage();
            string qwertynotMessage = frans.QwertyNotMessage();
            string nokeyboardselectedMessage = frans.NoKeyboardSelectedMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage,
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage,
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage,
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage,
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty, azerty, starttestingbtnMessage,
                foutMessage, azertynotMessage, qwertynotMessage, nokeyboardselectedMessage);
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
            string starttestingbtnMessage = spaans.StartTestingBtnTxtMessage();
            string succesvolopgeslagenMessage = spaans.OpslaanMessage();
            string voltooidMessage = spaans.VoltooidMessage();
            string filedoesntexistMessage = spaans.FileDoesntExistMessage();
            string filenotfoundMessage = spaans.FileNotFoundMesssage();
            string rectanglemarkedMessage = spaans.RectanglesMarkedMessage();
            string completedMessage = spaans.CompletedMessage();
            string foutMessage = spaans.ErrorMessage();
            string azertynotMessage = spaans.AzertyNotMessage();
            string qwertynotMessage = spaans.QwertyNotMessage();
            string nokeyboardselectedMessage = spaans.NoKeyboardSelectedMessage();

            AZERTY azerty = new AZERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage,
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage,
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            QWERTY qwerty = new QWERTY(greenMessage, grayMessage, jsonsaveMessage, jsonsearchMessage,
                jsonsavebtnMessage, jsonsearchbtnMessage, succesvolopgeslagenMessage, voltooidMessage,
                filedoesntexistMessage, filenotfoundMessage, rectanglemarkedMessage, completedMessage);
            Start start = new Start(headerMessage, chooseMessage, qwerty, azerty, starttestingbtnMessage,
                foutMessage, azertynotMessage, qwertynotMessage, nokeyboardselectedMessage);
            start.Show();
            this.Hide();
        }
    }
}
