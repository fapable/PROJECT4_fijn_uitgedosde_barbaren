using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Visitor design pattern to verify login
//In the database will be checked if the given username and password are correct


namespace Jaar_1_Project_4 {
    class LoginVisitorPattern {
    }
    public interface IClassicOption<T> { //Interfaces offers the classic to visit and lambda way
        void ClassicVisit(IOptionVisitor<T> visitor);
        U LambdaVisit<U>(Func<U> onNone, Func<T, U> OnSomeUsernameLogin, Func<T, U> onSomePasswordLogin);
        T GetValue();
    }
    public interface IOptionVisitor<T> {
        void OnLoginCheck(); 
        void OnPassword(IClassicOption<string> IOptionObject);
        void OnUsername(IClassicOption<string> IOptionObject);
        void OnNone();
    }
    public class TheVisitor<T> : IOptionVisitor<string> {
        Dictionary<IClassicOption<string>, IClassicOption<string>> givenUsernameAndPassword; //In this the username and password are stored
        IClassicOption<string> none; //To avoid creating null''s
        public TheVisitor() {
            none = new NoneLogin();
            this.givenUsernameAndPassword = new Dictionary<IClassicOption<string>, IClassicOption<string>>();
            this.givenUsernameAndPassword.Add(none, none);
        }
        public void OnNone() {
            Debug.WriteLine("We got a none object here!, empty, null!");
            
        }
        public void OnLoginCheck() { //Estabilishes database connection
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Key.LambdaVisit(() => true, _ => false, _ => false)){ //Checks if the item key is none, in other words Null.
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
        public void OnPassword(IClassicOption<string> typedInPassword) { //Checks if the given password is not empty (0 length)
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Value.LambdaVisit(() => true, _ => false, _ => false)) {
                    this.givenUsernameAndPassword = new Dictionary<IClassicOption<string>, IClassicOption<string>>() { { item.Key, typedInPassword } };
                    //Updates the dictionary
                }
            }
        }
        public void OnUsername(IClassicOption<string> typedInUsername) {
            foreach (var item in this.givenUsernameAndPassword) {
                if (item.Key.LambdaVisit(() => true, _ => false, _ => false)) {
                    this.givenUsernameAndPassword = new Dictionary<IClassicOption<string>, IClassicOption<string>>() { { typedInUsername, item.Value } };
                }
            }
        }
    }
    public class SomeUsernameLogin : IClassicOption<string> { 
        private string value;
        public SomeUsernameLogin(string value) {
            this.value = value;
        }
        public void ClassicVisit(IOptionVisitor<string> visitor) {
            visitor.OnUsername(this);
        }
        public string GetValue() {
            return this.value;
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return OnSomeUsernameLogin(this.value);
        }
    }
    public class SomePasswordLogin : IClassicOption<string> {
        private string value;
        public SomePasswordLogin(string value) {
            this.value = value;
        }
        public void ClassicVisit(IOptionVisitor<string> visitor) {
            visitor.OnPassword(this);
        }

        public string GetValue() {
            return this.value;
        }

        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onSomePasswordLogin(this.value);
        }
    }
    public class NoneLogin : IClassicOption<string> {
        public void ClassicVisit(IOptionVisitor<string> visitor) {
            visitor.OnNone();
        }

        public string GetValue() {
            return "";
        }

        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onNone();
        }
    }
}

