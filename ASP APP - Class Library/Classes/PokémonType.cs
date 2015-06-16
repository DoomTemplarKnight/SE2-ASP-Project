using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_APP___Class_Library.Classes
{
    public class PokémonType
    {
        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public PokémonType(string naam)
        {
            this.naam = naam;
        }
    }
}
