using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_APP___Class_Library.Classes
{
    public class PokémonAanval
    {
        private string aanvalnaam;
        private Classes.PokémonType aanvaltype;
        private int level;
        private bool tm;

        public string AanvalNaam
        {
            get { return aanvalnaam; }
            set { aanvalnaam = value; }
        }

        public Classes.PokémonType AanvalType
        {
            get { return aanvaltype; }
            set { aanvaltype = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public bool TM
        {
            get { return tm;}
            set { tm = value; }
        }
    }
}
