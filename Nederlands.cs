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
        public override string GreenMessage()
        {
            return "Groen = Succesvol ingedrukt";
        }

        public override string GrayMessage()
        {
            return "Grijs = Niet ingedrukt / Onsuccesvol";
        }

        public override string JsonSaveTxtMessage()
        {
            return "Zet hier de naam die u het bestand wilt geven.";
        }

        public override string JsonSearchTxtMessage()
        {
            return "Plaats hier de naam van uw json-bestand.";
        }
        public override string JsonSaveBtnTxtMessage()
        {
            return "Opslaan in Json";
        }

        public override string JsonSearchBtnTxtMessage()
        {
            return "Gebruik bestaand bestand";
        }
        public override string StartTestingBtnTxtMessage()
        {
            return "Start Testen";
        }
        public override string OpslaanMessage()
        {
            return "Succesvol opgeslagen in:";
        }
        public override string VoltooidMessage()
        {
            return "Opgeslagen!";
        }
        public override string FileDoesntExistMessage()
        {
            return "Het opgegeven bestand bestaat niet!";
        }
        public override string FileNotFoundMesssage()
        {
            return "Bestand Niet Gevonden";
        }
        public override string RectanglesMarkedMessage()
        {
            return "Rechthoeken gemarkeerd zoals aangegeven in het JSON-bestand.";
        }
        public override string CompletedMessage()
        {
            return "Voltooid!";
        }
    }
}
