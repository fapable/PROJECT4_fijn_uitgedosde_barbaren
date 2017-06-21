using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Visitor design pattern to verify login
//In the database will be checked if the given username and password are correct

namespace Jaar_1_Project_4 {
    class LoginVisitorDesignPattern {
    }
    public interface IClassicOption<T> {
        void ClassicVisit<U>(IOptionVisitor visitor);
        U LambdaVisit<U>(Func<U> onNone, Func<T, U> onSome);
    }
    public interface IOptionVisitor {
        void OnSome(string value);
        void OnNone();
    }
    public class TheVisitor : IOptionVisitor {
        public void OnNone() { //When the user hasn't entered anything it will go here
            Debug.WriteLine("Nothing entered!"); //Debug writeline is used because console.writeline cant be used in WUP
        }
        public void OnSome(string value) { //Estabilishes database connection
            //TODO database connection
            Debug.WriteLine("Testing database connection......");
        }
    }
    public class SomeLogin<T> : IClassicOption<T> {
        public string value;
        public SomeLogin(string value) {
            this.value = value;
  
        }
        public void ClassicVisit<U>(IOptionVisitor visitor) {
            visitor.OnSome(this.value);
        }

        public U LambdaVisit<U>(Func<U> onNone, Func<T, U> onSome) {
            throw new NotImplementedException();
        }
    }
    public class NoneLogin<T> : IClassicOption<T> {
        public void ClassicVisit<U>(IOptionVisitor visitor) {
            visitor.OnNone();
        }
        public U LambdaVisit<U>(Func<U> onNone, Func<T, U> onSome) {
            throw new NotImplementedException();
        }
    }
}



