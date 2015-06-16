using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASP_APP___Class_Library
{
    public class Pokémon
    {
        private string naam;
        private string preevolutienaam;
        private int pokédexnr;
        private Classes.PokémonType primairtype;
        private Classes.PokémonType secondairtype;
        private string classificatie;
        private double hoogte;
        private double gewicht;
        private int capturerate;
        private int baseeggsteps;
        private int baseatk;
        private int basehp;
        private int basedef;
        private int basespdef;
        private int basespeed;
        private int basespatk;
        private string evolutiemethode;
        private string evolutielevel;

        private List<Classes.PokémonAanval> pokémonAanvallen;
        private List<Classes.PokémonAbility> pokémonAbilities;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Preevolutienaam
        {
            get { return preevolutienaam; }
            set { preevolutienaam = value; }
        }
        public int PokédexNr
        {
            get { return pokédexnr; }
            set { pokédexnr = value; }
        }
        public Classes.PokémonType PimairType
        {
            get { return primairtype; }
            set { primairtype = value; }
        }

        public Classes.PokémonType SecondairType
        {
            get { return secondairtype; }
            set { secondairtype = value; }
        }
        public string Classificatie
        {
            get { return classificatie; }
            set { classificatie = value; }
        }

        public double Hoogte
        {
            get { return hoogte; }
            set { hoogte = value; }
        }

        public double Gewicht
        {
            get { return gewicht; }
            set { gewicht = value; }
        }

        public int CaptureRate
        {
            get { return capturerate; }
            set { capturerate = value; }
        }

        public int BaseEggSteps
        {
            get { return baseeggsteps; }
            set { baseeggsteps = value; }
        }

        public int BaseATK
        {
            get { return baseatk; }
            set { baseatk = value; }
        }

        public int BaseHP
        {
            get { return basehp; }
            set { basehp = value; }
        }

        public int BaseDEF
        {
            get { return basedef; }
            set { basedef = value; }
        }

        public int BaseSPDEF
        {
            get { return basespdef; }
            set { basespdef = value; }
        }

        public int BaseSPEED
        {
            get { return basespeed; }
            set { basespeed = value; }
        }

        public int BaseSPATK
        {
            get { return basespatk; }
            set { BaseSPATK = value; }
        }

        public string EvolutieMethode
        {
            get { return evolutiemethode; }
            set { evolutiemethode = value; }
        }

        public string EvolutieLevel
        {
            get { return evolutielevel; }
            set { evolutielevel = value; }
        }

        public List<Classes.PokémonAanval> PokémonAanvallen
        {
            get { return pokémonAanvallen; }
            set { pokémonAanvallen = value; }
        }

        public List<Classes.PokémonAbility> PokémonAbilities
        {
            get { return pokémonAbilities; }
            set { pokémonAbilities = value; }
        }

        public Pokémon(string naam, string preevolutienaam, int pokédexnr, Classes.PokémonType primairtype, Classes.PokémonType secondairtype,
            string classificatie, double hoogte, double gewicht, int capturerate, int baseeggsteps, int baseatk, int basehp, int basedef,
            int basespdef, int basespeed, int basespatk, string evolutiemethode, string evolutielevel)
        {
            this.naam = naam;
            this.preevolutienaam = preevolutienaam;
            this.pokédexnr = pokédexnr;
            this.primairtype = primairtype;
            this.secondairtype = secondairtype;
            this.classificatie = classificatie;
            this.hoogte = hoogte;
            this.gewicht = gewicht;
            this.capturerate = capturerate;
            this.baseeggsteps = baseeggsteps;
            this.baseatk = baseatk;
            this.basedef = basedef;
            this.basespatk = basespatk;
            this.basespdef = basespdef;
            this.basespeed = basespeed;
            this.evolutiemethode = evolutiemethode;
            this.evolutielevel = evolutielevel;

            pokémonAbilities = new List<Classes.PokémonAbility>();
        }
    }
}
