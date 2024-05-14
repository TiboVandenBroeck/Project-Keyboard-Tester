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
        public override string GreenMessage()
        {
            return "Vert = Appui réussi";
        }

        public override string GrayMessage()
        {
            return "Gris = Pas pressé / Échec";
        }
        public override string JsonSaveTxtMessage()
        {
            return "Entrez ici le nom que vous souhaitez donner au fichier.";
        }

        public override string JsonSearchTxtMessage()
        {
            return "Placez le nom de votre fichier json ici.";
        }
        public override string JsonSaveBtnTxtMessage()
        {
            return "Enregistrer dans Json";
        }

        public override string JsonSearchBtnTxtMessage()
        {
            return "Utiliser le fichier existant";
        }
        public override string StartTestingBtnTxtMessage()
        {
            return "Commencer les tests";
        }
        public override string OpslaanMessage()
        {
            return "Enregistrement réussi dans :";
        }
        public override string VoltooidMessage()
        {
            return "Stocké!";
        }
        public override string FileDoesntExistMessage()
        {
            return "Le fichier spécifié n'existe pas!";
        }
        public override string FileNotFoundMesssage()
        {
            return "Fichier introuvable";
        }
        public override string RectanglesMarkedMessage()
        {
            return "Rectangles marqués comme indiqué dans le fichier JSON.";
        }
        public override string CompletedMessage()
        {
            return "Complété!";
        }
    }
}

