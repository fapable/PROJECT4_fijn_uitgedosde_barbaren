using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

//Checks the login in information

namespace Jaar_1_Project_4 {
    public abstract class DatabaseLoginCheck {
        private static bool isTeacherLoggedIn = false;
        public static bool IsTeacherLoggedInGetAndSettter { get => isTeacherLoggedIn; set => isTeacherLoggedIn = value; }

        public static bool LookUserNameAndPasswordInDB(IUserNameAndPasswordVisit<string>[] givenUserNameAndPassword) {
            var syncClient = new HttpClient(); //To make connection with the API

            string passwordQuery = "http://www.wschaijk.nl/api/api.php/SELECT-teacher_code-FROM-teachers-WHERE-teacher_id=" + "'" + givenUserNameAndPassword[0].GetLoginInformationValue() + "';";
 
            var passwordCall = syncClient.GetStringAsync(passwordQuery); //Query call
            var passwordResult = passwordCall.Result; //Query result is saved
    
            string passwordDBConverted = DatabaseLoginCheck.ConvertRawQueryToText(passwordResult);

            return CheckUserNameAndPassword(passwordDBConverted, givenUserNameAndPassword[1].GetLoginInformationValue());
        }
        public static string ConvertRawQueryToText(string usernameOrPassword) {
            string emptyUserNameAndPassword = "";
            string secondemptyUserNameAndPassword = "";
            foreach (char character in usernameOrPassword.Reverse()) {
                if (character.ToString() == ":") {
                    break;
                }
                if (character.ToString() == "\"" || character.ToString() == "}") {
                    emptyUserNameAndPassword += "";
                }
                else {
                    emptyUserNameAndPassword += character.ToString();
                }
            }
            foreach (char item in emptyUserNameAndPassword.Reverse()) {
                secondemptyUserNameAndPassword += item;
            }
            return secondemptyUserNameAndPassword;
        }
        public static bool CheckUserNameAndPassword(string passwordDB,  string givenPassword) {
           if (passwordDB == "") {
                ErrorTextAttributeFactory.GetAndSetErrorMessage = ErrorTextAttributeFactory.errorMessageEnum.wrongUsername;
                return false;
            }
            else if (passwordDB != givenPassword) {
                ErrorTextAttributeFactory.GetAndSetErrorMessage = ErrorTextAttributeFactory.errorMessageEnum.wrongPassword;
                return false;
            }
            else {
                return true;
            }
        }
    }
}