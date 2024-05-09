using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Keyboard_Tester
{
    internal class Frans : Talen
    {
        public override string HeaderMessage()
        {
            return "Programme de test du clavier";
        }
        public override string ChooseMessage()
        {
            return "Choisissez un type de clavier";
        }
    }
}
