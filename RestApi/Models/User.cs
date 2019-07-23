using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private string _email;

        public User(long id, string login, string firstname, string lastname, string email, DateTime birthDate)
        {
            Id = id;
            Login = login;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            BirthDate = birthDate;
        }

        public User()
        {

        }

        public long Id { get; set; }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                //if (value.Length > 12)
                //{
                //    throw new ArgumentException("Login should be max 12 leters");
                //}
                _login = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                //if (value.Length > 8)
                //{
                //    throw new ArgumentException("First Name should be max 8 leters");
                //}
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                //if (value.Length > 8)
                //{
                //    throw new ArgumentException("Last Name should be max 8 leters");
                //}
                _lastName = value;
            }
        }

        public DateTime LastEnterDate { get; set; }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                //if (value.Length > 20)
                //{
                //    throw new ArgumentException("Email should be max 20 leters");
                //}
                _email = value;
            }
        }

        public DateTime BirthDate { get; set; }
    }
}
