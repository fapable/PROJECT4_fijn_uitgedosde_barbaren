﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Jaar_1_Project_4 {
    public abstract class ErrorTextAttributeFactory {
        private static errorMessageEnum errorMessage;
        public enum errorMessageEnum { wrongUsername, wrongPassword }
        public static errorMessageEnum GetAndSetErrorMessage { get => errorMessage; set => errorMessage = value; }
        public static void TheErrorTextAttributeFactory(TextBlock textblock) {
            switch (errorMessage) {
                case errorMessageEnum.wrongUsername:
                    textblock.Text = "Wrong username";
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
