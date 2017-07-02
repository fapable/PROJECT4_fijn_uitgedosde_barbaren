using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Visitor design pattern to verify login
//In the database will be checked if the given username and password are correct

namespace Jaar_1_Project_4 {
    public class TheVisitor<T> : ILoginVisitor<string> {
        //In the dictionary the username and password is stored
        Dictionary<IUserNameAndPasswordVisit<string>, IUserNameAndPasswordVisit<string>> givenUsernameAndPassword; 
        IUserNameAndPasswordVisit<string> none; //To avoid creating null objects

        public TheVisitor() {
            none = new NoneLogin();
            this.givenUsernameAndPassword = new Dictionary<IUserNameAndPasswordVisit<string>, IUserNameAndPasswordVisit<string>>();
            this.givenUsernameAndPassword.Add(none, none);
        }
        public void OnNone() {
            Debug.WriteLine("We got a none object here");         
        }
        //Checks if there is an username and password entered, and will then estabalish database connection
        public void OnLoginCheck() { 
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Key.LambdaVisit(() => true, _ => false, _ => false)){ //Checks if the password or username is fileld in
                    Debug.WriteLine("No username entered!");
                }
                else if (item.Value.LambdaVisit(() => true, _ => false, _ => false)) { 
                    Debug.WriteLine("No password entered");
                }
                else {
                    //TODO see if the entered username and password match with each other
                    Debug.WriteLine("We make database connection now since username nad password are filled in!");
                }
            }
        }
        //Checks if the password is filled in
        public void OnPassword(IUserNameAndPasswordVisit<string> typedInPassword) {
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Value.LambdaVisit(() => true, _ => false, _ => false)) {
                    this.givenUsernameAndPassword = new Dictionary<IUserNameAndPasswordVisit<string>, IUserNameAndPasswordVisit<string>>() { { item.Key, typedInPassword } };
                    //Updates the dictionary
                }
            }
        }
        //Checks if the username is filled in
        public void OnUsername(IUserNameAndPasswordVisit<string> typedInUsername) {
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Key.LambdaVisit(() => true, _ => false, _ => false)) {
                    this.givenUsernameAndPassword = new Dictionary<IUserNameAndPasswordVisit<string>, IUserNameAndPasswordVisit<string>>() { { typedInUsername, item.Value } };
                }
            }
        }
    }
    //The username concrete class
    public class SomeUsernameLogin : IUserNameAndPasswordVisit<string> { 
        private string username;
        public SomeUsernameLogin(string username) {
            this.username = username;
        }
        public void NoLamdaVisit(ILoginVisitor<string> visitor) {
            visitor.OnUsername(this);
        }
        public string GetLoginInformationValue() {
            return this.username;
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return OnSomeUsernameLogin(this.username);
        }
    }
    //The password concrete class
    public class SomePasswordLogin : IUserNameAndPasswordVisit<string> {
        private string password;
        public SomePasswordLogin(string value) {
            this.password = value;
        }
        public void NoLamdaVisit(ILoginVisitor<string> visitor) {
            visitor.OnPassword(this);
        }
        public string GetLoginInformationValue() {
            return this.password;
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onSomePasswordLogin(this.password);
        }
    }
    //Concrete classs to avoid null objects
    public class NoneLogin : IUserNameAndPasswordVisit<string> {
        public void NoLamdaVisit(ILoginVisitor<string> visitor) {
            visitor.OnNone();
        }
        public string GetLoginInformationValue() {
            return "";
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onNone();
        }
    }
}

