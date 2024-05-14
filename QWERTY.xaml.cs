using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace Project_Keyboard_Tester
{
    /// <summary>
    /// Interaction logic for QWERTY.xaml
    /// </summary>
    public partial class QWERTY : Window
    {
        private Keychecker keychecker;

        private string succesVolOpgeslaanText;
        private string voltooid;
        private string filedoesnexist;
        private string filenotfound;
        private string rectanglemarked;
        private string completed;

        public QWERTY(string GreenLabelText, string GrayLabelText, string JsonSaveText, string JsonSearchText, 
            string JsonSaveBtnText, string JsonSearchBtnText, string SuccesVolOpgeslaanText, string Voltooid,
            string FileDoesntExistText, string FileNotFoundText, string RectangleMarkedText, string Completed)
        {
            InitializeComponent();

            greenlbl.Content = GreenLabelText;
            grijslbl.Content = GrayLabelText;
            jsonsavetextbox.Text = JsonSaveText;
            jsonsearchtextbox.Text = JsonSearchText;
            Jsonsavebtn.Content = JsonSaveBtnText;
            jsonopenbtn.Content = JsonSearchBtnText;

            keychecker = new Keychecker();

            this.succesVolOpgeslaanText = SuccesVolOpgeslaanText;
            this.voltooid = Voltooid;
            this.filedoesnexist = FileDoesntExistText;
            this.filenotfound = FileNotFoundText;
            this.rectanglemarked = RectangleMarkedText;
            this.completed = Completed;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            keychecker.AddWorkingKey(e.Key.ToString());

            switch (e.Key)
            {
                case Key.Enter when Keyboard.IsKeyToggled(Key.NumLock):
                    REnter.Fill = Brushes.Green;
                    keychecker.AddWorkingKey("REnter");
                    break;
                default:
                    break;

            }
            switch (e.Key)
            {
                case Key.Escape:
                    Escape.Fill = Brushes.Green;
                    break;
                case Key.F1:
                    F1.Fill = Brushes.Green;
                    break;
                case Key.F2:
                    F2.Fill = Brushes.Green;
                    break;
                case Key.F3:
                    F3.Fill = Brushes.Green;
                    break;
                case Key.F4:
                    F4.Fill = Brushes.Green;
                    break;
                case Key.F5:
                    F5.Fill = Brushes.Green;
                    break;
                case Key.F6:
                    F6.Fill = Brushes.Green;
                    break;
                case Key.F7:
                    F7.Fill = Brushes.Green;
                    break;
                case Key.F8:
                    F8.Fill = Brushes.Green;
                    break;
                case Key.F9:
                    F9.Fill = Brushes.Green;
                    break;
                case Key.System:
                    if (e.SystemKey == Key.F10)
                    {
                        F10.Fill = Brushes.Green;
                        break;
                        e.Handled = true;
                    }
                    break;
                case Key.F11:
                    F11.Fill = Brushes.Green;
                    break;
                case Key.F12:
                    F12.Fill = Brushes.Green;
                    break;
                //wordt weldegelijk ingeduwd maar geeft niets terug.
                case Key.PrintScreen:
                    PrintScreen.Fill = Brushes.Green;
                    break;
                case Key.Scroll:
                    Scroll.Fill = Brushes.Green;
                    break;
                case Key.Pause:
                    Pause.Fill = Brushes.Green;
                    break;
                case Key.OemQuotes:
                    OemQuotes.Fill = Brushes.Green;
                    break;
                case Key.D1:
                    D1.Fill = Brushes.Green;
                    break;
                case Key.D2:
                    D2.Fill = Brushes.Green;
                    break;
                case Key.D3:
                    D3.Fill = Brushes.Green;
                    break;
                case Key.D4:
                    D4.Fill = Brushes.Green;
                    break;
                case Key.D5:
                    D5.Fill = Brushes.Green;
                    break;
                case Key.D6:
                    D6.Fill = Brushes.Green;
                    break;
                case Key.D7:
                    D7.Fill = Brushes.Green;
                    break;
                case Key.D8:
                    D8.Fill = Brushes.Green;
                    break;
                case Key.D9:
                    D9.Fill = Brushes.Green;
                    break;
                case Key.D0:
                    D0.Fill = Brushes.Green;
                    break;
                case Key.OemOpenBrackets:
                    OemOpenBrackets.Fill = Brushes.Green;
                    break;
                case Key.OemCloseBrackets:
                    OemCloseBrackets.Fill = Brushes.Green;
                    break;
                case Key.OemMinus:
                    OemMinus.Fill = Brushes.Green;
                    break;
                case Key.Back:
                    Back.Fill = Brushes.Green;
                    break;
                case Key.Insert:
                    Insert.Fill = Brushes.Green;
                    break;
                case Key.Home:
                    Home.Fill = Brushes.Green;
                    break;
                case Key.PageUp:
                    PageUp.Fill = Brushes.Green;
                    break;
                case Key.NumLock:
                    NumLock.Fill = Brushes.Green;
                    break;
                case Key.Divide:
                    Divide.Fill = Brushes.Green;
                    break;
                case Key.Multiply:
                    Multiply.Fill = Brushes.Green;
                    break;
                case Key.Subtract:
                    Subtract.Fill = Brushes.Green;
                    break;
                case Key.Tab:
                    Tab.Fill = Brushes.Green;
                    break;
                case Key.A:
                    A.Fill = Brushes.Green;
                    break;
                case Key.Z:
                    Z.Fill = Brushes.Green;
                    break;
                case Key.E:
                    E.Fill = Brushes.Green;
                    break;
                case Key.R:
                    R.Fill = Brushes.Green;
                    break;
                case Key.T:
                    T.Fill = Brushes.Green;
                    break;
                case Key.Y:
                    Y.Fill = Brushes.Green;
                    break;
                case Key.U:
                    U.Fill = Brushes.Green;
                    break;
                case Key.I:
                    I.Fill = Brushes.Green;
                    break;
                case Key.O:
                    O.Fill = Brushes.Green;
                    break;
                case Key.P:
                    P.Fill = Brushes.Green;
                    break;
                case Key.Oem1:
                    Oem1.Fill = Brushes.Green;
                    break;
                case Key.Enter when !Keyboard.IsKeyToggled(Key.NumLock):
                    REnter.Fill = Brushes.Green;
                    break;
                case Key.Delete:
                    Delete.Fill = Brushes.Green;
                    break;
                case Key.End:
                    End.Fill = Brushes.Green;
                    break;
                case Key.PageDown:
                    PageDown.Fill = Brushes.Green;
                    break;
                case Key.NumPad7:
                    NumPad7.Fill = Brushes.Green;
                    break;
                case Key.NumPad8:
                    NumPad8.Fill = Brushes.Green;
                    break;
                case Key.NumPad9:
                    NumPad9.Fill = Brushes.Green;
                    break;
                case Key.Add:
                    Add.Fill = Brushes.Green;
                    break;
                case Key.CapsLock:
                    CapsLock.Fill = Brushes.Green;
                    break;
                case Key.Q:
                    Q.Fill = Brushes.Green;
                    break;
                case Key.S:
                    S.Fill = Brushes.Green;
                    break;
                case Key.D:
                    D.Fill = Brushes.Green;
                    break;
                case Key.F:
                    F.Fill = Brushes.Green;
                    break;
                case Key.G:
                    G.Fill = Brushes.Green;
                    break;
                case Key.H:
                    H.Fill = Brushes.Green;
                    break;
                case Key.J:
                    J.Fill = Brushes.Green;
                    break;
                case Key.K:
                    K.Fill = Brushes.Green;
                    break;
                case Key.L:
                    L.Fill = Brushes.Green;
                    break;
                case Key.M:
                    M.Fill = Brushes.Green;
                    break;
                case Key.Oem3:
                    Oem3.Fill = Brushes.Green;
                    break;
                case Key.Oem5:
                    Oem5.Fill = Brushes.Green;
                    break;
                case Key.NumPad4:
                    NumPad4.Fill = Brushes.Green;
                    break;
                case Key.NumPad5:
                    NumPad5.Fill = Brushes.Green;
                    break;
                case Key.NumPad6:
                    NumPad6.Fill = Brushes.Green;
                    break;
                case Key.LeftShift:
                    LeftShift.Fill = Brushes.Green;
                    break;
                /*case Key.OemBackslash:
                    OemBackslash.Fill = Brushes.Green;
                    break;*/
                case Key.W:
                    W.Fill = Brushes.Green;
                    break;
                case Key.X:
                    X.Fill = Brushes.Green;
                    break;
                case Key.C:
                    C.Fill = Brushes.Green;
                    break;
                case Key.V:
                    V.Fill = Brushes.Green;
                    break;
                case Key.B:
                    B.Fill = Brushes.Green;
                    break;
                case Key.N:
                    N.Fill = Brushes.Green;
                    break;
                case Key.OemComma:
                    OemComma.Fill = Brushes.Green;
                    break;
                case Key.OemPeriod:
                    OemPeriod.Fill = Brushes.Green;
                    break;
                case Key.Oem2:
                    Oem2.Fill = Brushes.Green;
                    break;
                case Key.OemPlus:
                    OemPlus.Fill = Brushes.Green;
                    break;
                case Key.RightShift:
                    RightShift.Fill = Brushes.Green;
                    break;
                case Key.Up:
                    Up.Fill = Brushes.Green;
                    break;
                case Key.NumPad1:
                    NumPad1.Fill = Brushes.Green;
                    break;
                case Key.NumPad2:
                    NumPad2.Fill = Brushes.Green;
                    break;
                case Key.NumPad3:
                    NumPad3.Fill = Brushes.Green;
                    break;
                case Key.LeftCtrl:
                    LeftCtrl.Fill = Brushes.Green;
                    break;
                case Key.LWin:
                    LWin.Fill = Brushes.Green;
                    break;
                case Key.LeftAlt:
                    LeftAlt.Fill = Brushes.Green;
                    break;
                case Key.RightAlt:
                    RightAlt.Fill = Brushes.Green;
                    break;
                case Key.Space:
                    Space.Fill = Brushes.Green;
                    break;
                //functie key kan niet getecteerd worden!!!!
                case Key.Apps:
                    Apps.Fill = Brushes.Green;
                    break;
                case Key.RightCtrl:
                    RightCtrl.Fill = Brushes.Green;
                    break;
                case Key.Left:
                    Left.Fill = Brushes.Green;
                    break;
                case Key.Down:
                    Down.Fill = Brushes.Green;
                    break;
                case Key.Right:
                    Right.Fill = Brushes.Green;
                    break;
                case Key.NumPad0:
                    NumPad0.Fill = Brushes.Green;
                    break;
                case Key.Decimal:
                    Decimal.Fill = Brushes.Green;
                    break;
                default:
                    break;
            }
        }


        private void Jsonsavebtn_Click(object sender, RoutedEventArgs e)
        {
            string jsonContent = jsonsavetextbox.Text;

            string fileName = $"{jsonContent}.json";

            string directoryPath = @"D:\Vives 1-2\OOP\Project Keyboard-Tester";
            string filePath = System.IO.Path.Combine(directoryPath, fileName);

            keychecker.SaveToJson(filePath);

            MessageBox.Show($"{GetSuccesVolOpgeslaanText()}\n{filePath}",
                GetVoltooidText(), MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void jsonopenbtn_Click(object sender, RoutedEventArgs e)
        {
            // Haal de bestandsnaam op uit jsonsearchtextbox
            string fileName = jsonsearchtextbox.Text;

            // Controleer of de bestandsnaam eindigt op ".json" en voeg het toe als dat niet het geval is
            if (!fileName.EndsWith(".json"))
            {
                fileName += ".json";
            }

            // Bepaal het volledige pad naar het JSON-bestand
            string directoryPath = @"D:\Vives 1-2\OOP\Project Keyboard-Tester";
            string filePath = System.IO.Path.Combine(directoryPath, fileName);

            // Controleer of het bestand bestaat
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"{GetFileDoesntExistText()}", GetFileNotFoundText(),
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Lees de inhoud van het JSON-bestand
            string jsonContent = File.ReadAllText(filePath);

            // Deserialiseer de JSON-inhoud naar een geschikt object
            List<string> rectangleNames = JsonConvert.DeserializeObject<List<string>>(jsonContent);

            // Itereer door de deserialiseerde objecten en zoek de overeenkomende rechthoeken
            foreach (string rectangleName in rectangleNames)
            {
                // Zoek de rechthoek met de overeenkomende naam
                Rectangle foundRectangle = (Rectangle)FindName(rectangleName);

                if (foundRectangle != null)
                {
                    foundRectangle.Fill = Brushes.Green;
                }
            }

            MessageBox.Show($"{GetRectangleMarkedText()}", GetCompleted(),
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public string GetSuccesVolOpgeslaanText()
        {
            return succesVolOpgeslaanText;
        }

        public string GetVoltooidText()
        {
            return voltooid;
        }

        public string GetFileDoesntExistText()
        {
            return filedoesnexist;
        }

        public string GetFileNotFoundText()
        {
            return filenotfound;
        }
        public string GetRectangleMarkedText()
        {
            return rectanglemarked;
        }
        public string GetCompleted()
        {
            return completed;
        }
    }
}