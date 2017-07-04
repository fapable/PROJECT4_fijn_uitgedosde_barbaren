using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http; //To create the database query

//The main job is to check if the given username teacher and password teacher is correct

namespace Jaar_1_Project_4 {
    public abstract class DatabaseLoginCheck {
        //The getter and setter is static because everywhere in the program, the value must be the same
        private static bool isTeacherLoggedIn = false; 
        public static bool IsTeacherLoggedInGetAndSettter { get => isTeacherLoggedIn; set => isTeacherLoggedIn = value; } 

        //Main job is to create a query to check if the given user information is correct
        public static bool CheckGivenPasswordInDatabase(IUserNameAndPasswordVisit<string>[] givenUserNameAndPassword) {
            var syncClient = new HttpClient(); //To make connection with the API for the database
            string passwordQuery = "http://www.wschaijk.nl/api/api.php/SELECT-teacher_code-FROM-teachers-WHERE-teacher_id=" + "'" + givenUserNameAndPassword[0].GetLoginInformationValue() + "';";
            var passwordCall = syncClient.GetStringAsync(passwordQuery); //Query gets executed
            var passwordResult = passwordCall.Result; //Query result is stored
    
            //The query password result is first converted to take out the brackets and other symbols 
            string passwordDBConverted = DatabaseLoginCheck.ConvertRawQueryToText(passwordResult);

            //Checks wherever the given user information is correct
            return IsCorrectUserInformation(passwordDBConverted, givenUserNameAndPassword[1].GetLoginInformationValue());
        }
        //Main job is to make the query result more pretty, it takes out brackets and other symbols
        public static string ConvertRawQueryToText(string queryPasswordResult) {
            string reversedPassword = ""; //In the loop the query result is reversed to reach it better
            string reReversedPassword = ""; //The final result of the query result will be stored in this
            foreach (char character in queryPasswordResult.Reverse()) { //reverse loop
                if (character.ToString() == ":") { //When it reached the double dots, it knows it has to stop
                    break;
                }
                if (character.ToString() == "\"" || character.ToString() == "}") { //Brackets get taken out
                    reversedPassword += "";
                }
                else {
                    reversedPassword += character.ToString(); 
                }
            }
            //Since the query result is reversed, it will now become re-reversed to make it not reversed anymore
            foreach (char character in reversedPassword.Reverse()) { 
                reReversedPassword += character; 
            }
            return reReversedPassword; //Returns the final query result, all brackets and other symbols have been taken out
        }
        //Main job is to check if the given user information is correct
        public static bool IsCorrectUserInformation(string convertedPasswordFromTheDatabase,  string typedInPassword) {
           if (convertedPasswordFromTheDatabase == "") { //If the result is empty, then it means that user does not exist in the database or it is wrongly spelled
                ErrorTextAttributeFactory.GetAndSetErrorMessage = ErrorTextAttributeFactory.errorMessageEnum.wrongUsername;
                return false;
            }
            else if (convertedPasswordFromTheDatabase != typedInPassword) { //Checks if the DB password matches the given password
                ErrorTextAttributeFactory.GetAndSetErrorMessage = ErrorTextAttributeFactory.errorMessageEnum.wrongPassword;
                return false;
            }
            else {
                return true;
            }
        }
    }
}