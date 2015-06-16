using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_APP___Class_Library.Classes
{
    public class Gebruiker
    {
        private int userID;
        private string gebruikersnaam;
        private string wachtwoord;
        private string emailadres;
        private string function;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public string Emailadres
        {
            get { return emailadres; }
            set { emailadres = value; }
        }

        public string Function
        {
            get { return function; }
            set { function = value; }
        }

        public Gebruiker(int id, string gebruikersnaam, string wachtwoord, string emailadres, string function)
        {
            this.userID = id;
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.emailadres = emailadres;
            this.function = function;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
