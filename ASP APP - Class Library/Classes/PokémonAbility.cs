using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_APP___Class_Library.Classes
{
    public class PokémonAbility
    {
        private string naam;
        private string beschrijving;
        private string effect;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Beschrijving
        {
            get { return beschrijving; }
            set { beschrijving = value; }
        }

        public string Effect
        {
            get { return effect; }
            set { effect = value; }
        }

        public PokémonAbility(string naam, string beschrijving, string effect)
        {
            this.naam = naam;
            this.beschrijving = beschrijving;
            this.effect = effect;
        }
    }
}
