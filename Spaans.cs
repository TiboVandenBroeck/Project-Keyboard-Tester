using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Keyboard_Tester
{
    internal class Spaans : Talen
    {
        public override string HeaderMessage()
        {
            return "Programa de prueba de teclado";
        }
        public override string ChooseMessage()
        {
            return "Elige un tipo de teclado";
        }
    }
}
