﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Visitor design pattern to verify login
//In the database will be checked if the given username and password are correct

namespace Jaar_1_Project_4 {
    public class LogInInformationStoreVisitor<T> : ILoginVisitor<string> {
        //In the array the username and password is stored
        IUserNameAndPasswordVisit<string>[] usernameAndPassword;
        public LogInInformationStoreVisitor() {
            this.usernameAndPassword = new IUserNameAndPasswordVisit<string>[2];
        }
        public void OnNone() {
            Debug.WriteLine("We got a none object here");
        }
        //estabalishes database connection
        public bool OnLoginCheck() {
            return DatabaseLoginCheck.LookUserNameAndPasswordInDB(usernameAndPassword);
        }
        public void OnPassword(IUserNameAndPasswordVisit<string> typedInPassword) {
            usernameAndPassword[0] = typedInPassword;
        }
        public void OnUsername(IUserNameAndPasswordVisit<string> typedInUsername) {
            usernameAndPassword[1] = typedInUsername;
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

