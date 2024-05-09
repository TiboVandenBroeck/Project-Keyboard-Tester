using System.Text;
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
    /// Interaction logic for AZERTY.xaml
    /// </summary>
    public partial class AZERTY : Window
    {
        public AZERTY()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.Enter when Keyboard.IsKeyToggled(Key.NumLock):
                    RNumEnter.Fill = Brushes.Green;
                    break;
                default:
                    break;

            }
            switch (e.Key)
            {
                case Key.Escape:
                    RESC.Fill = Brushes.Green;
                    break;
                case Key.F1:
                    RF1.Fill = Brushes.Green;
                    break;
                case Key.F2:
                    RF2.Fill = Brushes.Green;
                    break;
                case Key.F3:
                    RF3.Fill = Brushes.Green;
                    break;
                case Key.F4:
                    RF4.Fill = Brushes.Green;
                    break;
                case Key.F5:
                    RF5.Fill = Brushes.Green;
                    break;
                case Key.F6:
                    RF6.Fill = Brushes.Green;
                    break;
                case Key.F7:
                    RF7.Fill = Brushes.Green;
                    break;
                case Key.F8:
                    RF8.Fill = Brushes.Green;
                    break;
                case Key.F9:
                    RF9.Fill = Brushes.Green;
                    break;
                case Key.F10:
                    RF10.Fill = Brushes.Green;
                    break;
                case Key.F11:
                    RF11.Fill = Brushes.Green;
                    break;
                case Key.F12:
                    RF12.Fill = Brushes.Green;
                    break;
                    //wordt weldegelijk ingeduwd maar geeft niets terug.
                case Key.PrintScreen:
                    RPrntscrn.Fill = Brushes.Green;
                    break;
                case Key.Scroll:
                    RScrlllck.Fill = Brushes.Green;
                    break;
                case Key.Pause:
                    RPause.Fill = Brushes.Green;
                    break;
                case Key.OemQuotes:
                    RMacht.Fill = Brushes.Green;
                    break;
                case Key.D1:
                    Rone.Fill = Brushes.Green;
                    break;
                case Key.D2:
                    Rtwo.Fill = Brushes.Green;
                    break;
                case Key.D3:
                    Rthree.Fill = Brushes.Green;
                    break;
                case Key.D4:
                    Rfour.Fill = Brushes.Green;
                    break;
                case Key.D5:
                    Rfive.Fill = Brushes.Green;
                    break;
                case Key.D6:
                    Rsix.Fill = Brushes.Green;
                    break;
                case Key.D7:
                    Rseven.Fill = Brushes.Green;
                    break;
                case Key.D8:
                    Reight.Fill = Brushes.Green;
                    break;
                case Key.D9:
                    Rnine.Fill = Brushes.Green;
                    break;
                case Key.D0:
                    Rzero.Fill = Brushes.Green;
                    break;
                case Key.OemOpenBrackets:
                    RCelcius.Fill = Brushes.Green;
                    break;
                case Key.OemCloseBrackets:
                    RPiramid.Fill = Brushes.Green;
                    break;
                case Key.OemMinus:
                    R_.Fill = Brushes.Green;
                    break;
                case Key.Back:
                    RBack.Fill = Brushes.Green;
                    break;
                case Key.Insert:
                    RInsert.Fill = Brushes.Green;
                    break;
                case Key.Home:
                    RHome.Fill = Brushes.Green;
                    break;
                case Key.PageUp:
                    RUp.Fill = Brushes.Green;
                    break;
                case Key.NumLock:
                    RNumlock.Fill = Brushes.Green;
                    break;
                case Key.Divide:
                    RDash.Fill = Brushes.Green;
                    break;
                case Key.Multiply:
                    RMultipl.Fill = Brushes.Green;
                    break;
                case Key.Subtract:
                    RStreep.Fill = Brushes.Green;
                    break;
                case Key.Tab:
                    RTab.Fill = Brushes.Green;
                    break;
                case Key.A:
                    RA.Fill = Brushes.Green;
                    break;
                case Key.Z:
                    RZ.Fill = Brushes.Green;
                    break;
                case Key.E:
                    RE.Fill = Brushes.Green;
                    break;
                case Key.R:
                    RR.Fill = Brushes.Green;
                    break;
                case Key.T:
                    RT.Fill = Brushes.Green;
                    break;
                case Key.Y:
                    RY.Fill = Brushes.Green;
                    break;
                case Key.U:
                    RU.Fill = Brushes.Green;
                    break;
                case Key.I:
                    RI.Fill = Brushes.Green;
                    break;
                case Key.O:
                    RO.Fill = Brushes.Green;
                    break;
                case Key.P:
                    RP.Fill = Brushes.Green;
                    break;
                case Key.Oem1:
                    RDollar.Fill = Brushes.Green;
                    break;
                case Key.Enter when !Keyboard.IsKeyToggled(Key.NumLock):
                    REnter.Fill = Brushes.Green;
                    break;
                case Key.Delete:
                    RDel.Fill = Brushes.Green;
                    break;
                case Key.End:
                    REnd.Fill = Brushes.Green;
                    break;
                case Key.PageDown:
                    RPagedown.Fill = Brushes.Green;
                    break;
                case Key.NumPad7:
                    R7.Fill = Brushes.Green;
                    break;
                case Key.NumPad8:
                    R8.Fill = Brushes.Green;
                    break;
                case Key.NumPad9:
                    R9.Fill = Brushes.Green;
                    break;
                case Key.Add:
                    RPlus.Fill = Brushes.Green;
                    break;
                case Key.CapsLock:
                    RCapslock.Fill = Brushes.Green;
                    break;
                case Key.Q:
                    RQ.Fill = Brushes.Green;
                    break;
                case Key.S:
                    RS.Fill = Brushes.Green;
                    break;
                case Key.D:
                    RD.Fill = Brushes.Green;
                    break;
                case Key.F:
                    RF.Fill = Brushes.Green;
                    break;
                case Key.G:
                    RG.Fill = Brushes.Green;
                    break;
                case Key.H:
                    RH.Fill = Brushes.Green;
                    break;
                case Key.J:
                    RJ.Fill = Brushes.Green;
                    break;
                case Key.K:
                    RK.Fill = Brushes.Green;
                    break;
                case Key.L:
                    RL.Fill = Brushes.Green;
                    break;
                case Key.M:
                    RM.Fill = Brushes.Green;
                    break;
                case Key.Oem3:
                    Rù.Fill = Brushes.Green;
                    break;
                case Key.Oem5:
                    Rµ.Fill = Brushes.Green;
                    break;
                case Key.NumPad4:
                    R4.Fill = Brushes.Green;
                    break;
                case Key.NumPad5:
                    R5.Fill = Brushes.Green;
                    break;
                case Key.NumPad6:
                    R6.Fill = Brushes.Green;
                    break;
                case Key.LeftShift:
                    RLeftshift.Fill = Brushes.Green;
                    break;
                case Key.OemBackslash:
                    RBek.Fill = Brushes.Green;
                    break;
                case Key.W:
                    RW.Fill = Brushes.Green;
                    break;
                case Key.X:
                    RX.Fill = Brushes.Green;
                    break;
                case Key.C:
                    RC.Fill = Brushes.Green;
                    break;
                case Key.V:
                    RV.Fill = Brushes.Green;
                    break;
                case Key.B:
                    RB.Fill = Brushes.Green;
                    break;
                case Key.N:
                    RN.Fill = Brushes.Green;
                    break;
                case Key.OemComma:
                    RQuestion.Fill = Brushes.Green;
                    break;
                case Key.OemPeriod:
                    RPunt.Fill = Brushes.Green;
                    break;
                case Key.Oem2:
                    RDubbelpunt.Fill = Brushes.Green;
                    break;
                case Key.OemPlus:
                    Recual.Fill = Brushes.Green;
                    break;
                case Key.RightShift:
                    RRightshift.Fill = Brushes.Green;
                    break;
                case Key.Up:
                    RArrowup.Fill = Brushes.Green;
                    break;
                case Key.NumPad1:
                    R1.Fill = Brushes.Green;
                    break;
                case Key.NumPad2:
                    R2.Fill = Brushes.Green;
                    break;
                case Key.NumPad3:
                    R3.Fill = Brushes.Green;
                    break;
                case Key.LeftCtrl:
                    RLeftctrl.Fill = Brushes.Green;
                    break;
                case Key.LWin:
                    RWindows.Fill = Brushes.Green;
                    break;
                case Key.LeftAlt:
                    RAlt.Fill = Brushes.Green;
                    break;
                case Key.RightAlt:
                    RAltgr.Fill = Brushes.Green;
                    break;
                case Key.Space:
                    RSpace.Fill = Brushes.Green;
                    break;
                //functie key kan niet getecteerd worden!!!!
                case Key.Apps:
                    RMenu.Fill = Brushes.Green;
                    break;
                case Key.RightCtrl:
                    Rrightctrl.Fill = Brushes.Green;
                    break;
                case Key.Left:
                    RArrowleft.Fill = Brushes.Green;
                    break;
                case Key.Down:
                    RArrowdown.Fill = Brushes.Green;
                    break;
                case Key.Right:
                    RArrowright.Fill = Brushes.Green;
                    break;
                case Key.NumPad0:
                    R0.Fill = Brushes.Green;
                    break;
                case Key.Decimal:
                    RNumpunt.Fill = Brushes.Green;
                    break;
                default:
                    break;
            }
        }


    }
}