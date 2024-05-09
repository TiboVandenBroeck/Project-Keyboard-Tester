using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Keyboard_Tester
{
    internal class Talen
    {
        public virtual string HeaderMessage()
        {
            return "Keyboard Test Program";
        }
        
        public virtual string ChooseMessage()
        {
            return "Choose Keyboard Type";
        }

        public virtual string GreenMessage()
        {
            return "Green = Pressed Succesfully";
        }

        public virtual string GrayMessage()
        {
            return "Gray = Not Pressed / Unsuccessful";
        }

        public virtual string JsonSaveTxtMessage()
        {
            return "Put the name you want to give the file here";
        }

        public virtual string JsonSearchTxtMessage()
        {
            return "Put the name of youre json file here";
        }

        public virtual string JsonSaveBtnTxtMessage()
        {
            return "Save to Json";
        }

        public virtual string JsonSearchBtnTxtMessage()
        {
            return "Use existing file";
        }
    }
}
