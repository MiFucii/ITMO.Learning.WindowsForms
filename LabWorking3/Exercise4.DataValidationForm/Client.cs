using System;

namespace Exercise4.DataValidationForm
{
    class Client
    {
        private string FirstName;
        public string Fname => FirstName;
        private string LastName;
        public string Lname => LastName;
        private string Email;
        public string email => Email;
        private byte Age;
        public byte age => Age;

        public Client(string Fn, string Ln, string email, byte age)
        {
            this.FirstName = Fn;
            this.LastName = Ln;
            this.Email = email;
            this.Age = age;
        }
    }
}
