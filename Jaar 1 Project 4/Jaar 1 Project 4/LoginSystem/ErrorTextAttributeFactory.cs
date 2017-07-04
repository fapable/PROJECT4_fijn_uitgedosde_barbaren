using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

//Main job of the factory is change the error message on the loginScreen

namespace Jaar_1_Project_4 {
    public abstract class ErrorTextAttributeFactory {
        private static errorMessageEnum errorMessage;
        public enum errorMessageEnum { wrongUsername, wrongPassword } //The enum to know which error message to show
        public static errorMessageEnum GetAndSetErrorMessage { get => errorMessage; set => errorMessage = value; }
        public static void TheErrorTextAttributeFactory(TextBlock textblock) { //An textblock comes in the method to change it's text
            switch (errorMessage) {
                case errorMessageEnum.wrongUsername:
                    textblock.Text = "Wrong username"; //Textblock's text gets changed
                    break;
                case errorMessageEnum.wrongPassword:
                    textblock.Text = "Wrong password";
                    break;
                default:
                    break;
            }
        }
    }
}

