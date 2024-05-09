using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Keyboard_Tester
{
    internal class Nederlands : Talen
    {
        public override string HeaderMessage()
        {
            return "Toetsenbord Test Programma";
        }
        public override string ChooseMessage()
        {
            return "Kies een keyboard type";
        }
    }
}
