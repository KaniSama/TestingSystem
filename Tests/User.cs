using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class User
    {
        private string Login, Password, LName, FName, FaName;
        private Rights UserRights;
        public enum Rights
        {
            Admin, User
        }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public User(string Login, string Password, string LName, string FName, string FaName)
        {
            this.Login = Login;
            this.Password = Password;
            this.LName = LName;
            this.FName = FName;
            this.FaName = FaName;
        }
        public User(string Login, string Password, string LName, string FName, string FaName, Rights UserRights)
        {
            this.Login = Login;
            this.Password = Password;
            this.LName = LName;
            this.FName = FName;
            this.FaName = FaName;
            this.UserRights = UserRights;
        }

        public string GetLogin()
        {
            return Login;
        }
        public string GetPassword()
        {
            return Password;
        }
        public Rights GetRights()
        {
            return UserRights;
        }
    }
}
