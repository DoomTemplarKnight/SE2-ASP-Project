using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ASP_APP___Class_Library.Classes
{
    public static class DRConverter
    {
        public static Pokémon ToPokémon(DataRow r)
        {
            Pokémon pokemon = new Pokémon(r["NAAM"].ToString(), r["PREEVOLUTIENAAM"].ToString(), Convert.ToInt32(r["POKEDEXNR"]),
                                    new PokémonType((r["PRIMAIRTYPENAAM"]).ToString()), new PokémonType((r["SECONDAIRTYPENAAM"]).ToString()),
                                    (r["CLASSIFICATIE"]).ToString(), Convert.ToInt32(r["HOOGTE"]), Convert.ToInt32(r["GEWICHT"]), Convert.ToInt32(r["CAPTURERATE"]),
                                    Convert.ToInt32(r["BASEEGGSTEPS"]), Convert.ToInt32(r["BASEATK"]), Convert.ToInt32(r["BASEHP"]), Convert.ToInt32(r["BASEDEF"]),
                                    Convert.ToInt32(r["BASESPDEF"]), Convert.ToInt32(r["BASESPEED"]), Convert.ToInt32(r["BASESPATK"]), r["EVOLUTIEMETHODE"].ToString(),
                                    r["EVOLUTIELEVEL"].ToString());
            return pokemon;
        }

        public static PokémonType ToType(DataRow r)
        {
            return new PokémonType(r["NAAM"].ToString());
        }

        public static Gebruiker ToUser(DataRow r)
        {
            return new Gebruiker(Convert.ToInt32(r["ID"]), r["GEBRUIKERSNAAM"].ToString(), r["WACHTWOORD"].ToString(), r["EMAILADRES"].ToString(), r["FUNCTIE"].ToString());
        }

        public static PokémonAbility ToAbility(DataRow r)
        {
            return new PokémonAbility(r["NAAM"].ToString(), r["BESCHRIJVING"].ToString(), r["EFFECT"].ToString());
        }
    }
}
