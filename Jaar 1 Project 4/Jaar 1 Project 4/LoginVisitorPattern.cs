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
    public interface IClassicOption<T> {
        void ClassicVisit(IOptionVisitor<T> visitor);
        U LambdaVisit<U>(Func<U> onNone, Func<T, U> OnSomeUsernameLogin, Func<T, U> onSomePasswordLogin);
    }
    public interface IOptionVisitor<T> {
        void OnLoginCheck();
        void OnPassword(IClassicOption<string> value);
        void OnUsername(IClassicOption<string> value);
        void OnNone();
    }
    public class TheVisitor<T> : IOptionVisitor<string> {
        private ListIterator<IClassicOption<string>> usernameAndPassword; //Regardless if the object is some or none, it will be put in the list
        public TheVisitor() {
            this.usernameAndPassword = new ListIterator<IClassicOption<string>>();
        }
        public void OnNone() { //When the user hasn't entered anything it will go here
            Debug.WriteLine("Nothing entered!"); //Debug writeline is used because console.writeline cant be used in WUP
        }
        public void OnLoginCheck() { //Estabilishes database connection
            //TODO database connection
            Debug.WriteLine("Testing database connection......");
        }

        public void OnPassword(IClassicOption<string> value) {
            throw new NotImplementedException();
        }

        public void OnUsername(IClassicOption<string> value) {
            this.usernameAndPassword.Reset();
            if (!this.usernameAndPassword.IsNotEmpty()) {
                {
                    while (usernameAndPassword.IsNotEmpty()) {
                        if (usernameAndPassword.GetCurrent().LambdaVisit(() => false, _ => true, _ => false)) {
                            usernameAndPassword.RemoveElement();
                            usernameAndPassword.Add(value);
                        }

                        else {
                            usernameAndPassword.Add(value);

                        }
                    }
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
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onSomePasswordLogin(this.value);
        }
    }
    public class NoneLogin : IClassicOption<string> {
        public void ClassicVisit(IOptionVisitor<string> visitor) {
            visitor.OnNone();
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<string, U> OnSomeUsernameLogin, Func<string, U> onSomePasswordLogin) {
            return onNone();
        }
    }
}

