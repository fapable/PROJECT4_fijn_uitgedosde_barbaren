using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Main job of the file is to store the username and password
//The visitor stores the username and password and visits the concrete username and password classes
//The none class is to avoid putting null

//Design patterns: Visitor design pattern and Null Object Pattern
//TODO use null object pattern

namespace Jaar_1_Project_4 {
    public class LogInInformationStoreVisitor<T> : ILoginVisitor<string> {
        //In the array the username and password is stored
        IUserNameAndPasswordVisit<string>[] usernameAndPassword;
        public LogInInformationStoreVisitor() {
            this.usernameAndPassword = new IUserNameAndPasswordVisit<string>[2]; 
        }
        public void OnNone() { //To handle null objects
            
        }
        //Stores the userInformation and checks if the given user information is correct
        public bool IsLoginInSucceded() {
            return DatabaseLoginCheck.CheckGivenPasswordInDatabase(usernameAndPassword); //Checks if given user information is correct
        }
        //Stores username in array
        public void OnUsername(IUserNameAndPasswordVisit<string> typedInUsername) { 
            usernameAndPassword[0] = typedInUsername;
        }
        //Stores password in array
        public void OnPassword(IUserNameAndPasswordVisit<string> typedInPassword) {
            usernameAndPassword[1] = typedInPassword;
        }

    }
    //The username is stored in this class and then also given to the visitor
    public class SomeUsernameLogin : IUserNameAndPasswordVisit<string> {
        private string username; //username stored 
        public SomeUsernameLogin(string username) {
            this.username = username;
        }
        //The visit method
        public void VisitTheLoginInformation(ILoginVisitor<string> visitor) {
            visitor.OnUsername(this);
        }
        //Returns usename
        public string GetLoginInformationValue() {
            return this.username;
        }
    }
    //The password is stored in this class and then also given to the visitor
    public class SomePasswordLogin : IUserNameAndPasswordVisit<string> {
        private string password; //password stored
        public SomePasswordLogin(string value) {
            this.password = value;
        }
        //The visit method
        public void VisitTheLoginInformation(ILoginVisitor<string> visitor) {
            visitor.OnPassword(this);
        }
        //Returns password
        public string GetLoginInformationValue() {
            return this.password;
        }
    }
    //The null class to avoid putting null's
    public class NoneLogin : IUserNameAndPasswordVisit<string> {
        //Visit method
        public void VisitTheLoginInformation(ILoginVisitor<string> visitor) {
            visitor.OnNone();
        }
        //Returns nothing
        public string GetLoginInformationValue() {
            return "";
        }
    }
}

