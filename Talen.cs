using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

        public virtual string StartTestingBtnTxtMessage()
        {
            return "Start testing";
        }

        public virtual string OpslaanMessage()
        {
            return "Saved Succesfully";
        }

        public virtual string VoltooidMessage()
        {
            return "Saved!";
        }

        public virtual string FileDoesntExistMessage()
        {
            return "The given file does not exist!";
        }
        public virtual string FileNotFoundMesssage()
        {
            return "File Not Found";
        }
        public virtual string RectanglesMarkedMessage()
        {
            return "Rectangles marked as indicated in the JSON file.";
        }
        public virtual string CompletedMessage()
        {
            return "Completed!";
        }
        public virtual string ErrorMessage()
        {
            return "Error!";
        }
        public virtual string AzertyNotMessage()
        {
            return "AZERTY-window is not initialized correctly.";
        }
        public virtual string QwertyNotMessage()
        {
            return "QWERTY-window is not initialized correctly.";
        }
        public virtual string NoKeyboardSelectedMessage()
        {
            return "No keyboard selected.";
        }

    }
}
