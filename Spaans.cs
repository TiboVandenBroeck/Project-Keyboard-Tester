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
        public override string GreenMessage()
        {
            return "Verde = Presionado exitosamente";
        }

        public override string GrayMessage()
        {
            return "Gris = No presionado / Sin éxito";
        }
        public override string JsonSaveTxtMessage()
        {
            return "Introduce aquí el nombre que quieres darle al archivo.";
        }

        public override string JsonSearchTxtMessage()
        {
            return "Coloque el nombre de su archivo json aquí.";
        }
        public override string JsonSaveBtnTxtMessage()
        {
            return "Guardar en Json";
        }

        public override string JsonSearchBtnTxtMessage()
        {
            return "Usar archivo existente";
        }

        public override string StartTestingBtnTxtMessage()
        {
            return "Empezar a probar";
        }
        public override string OpslaanMessage()
        {
            return "Guardado exitosamente en:";
        }
        public override string VoltooidMessage()
        {
            return "Almacenado!";
        }
        public override string FileDoesntExistMessage()
        {
            return "¡El archivo especificado no existe!";
        }
        public override string FileNotFoundMesssage()
        {
            return "Archivo no encontrado";
        }
        public override string RectanglesMarkedMessage()
        {
            return "Rectángulos marcados como se indica en el archivo JSON.";
        }
        public override string CompletedMessage()
        {
            return "¡Terminado!";
        }
        public override string ErrorMessage()
        {
            return "¡Equivocado!";
        }
        public override string AzertyNotMessage()
        {
            return "La ventana AZERTY no se inicializa correctamente.";
        }
        public override string QwertyNotMessage()
        {
            return "La ventana QWERTY no se inicializa correctamente.";
        }
        public override string NoKeyboardSelectedMessage()
        {
            return "No se seleccionó ningún teclado.";
        }
    }
}
