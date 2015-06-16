using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP_APP___Class_Library.Classes;

namespace ASP_APP___Class_Library.Classes
{
    /// <summary>
    /// This class is used an organizer between the site and the other classes and the database.
    /// It contains all Lists of the needed objects that will be loaded onto the Site where needed.
    /// </summary>
    public static class Organizer
    {
        #region fields
        private static List<Pokémon> pokémons;
        private static List<PokémonType> types;
        private static List<Gebruiker> gebruikers;
        private static Databasemanager database;
        #endregion

        #region properties
        public static List<Pokémon> Pokémons
        {
            get { return pokémons; }
            set { pokémons = value; }
        }

        public static List<PokémonType> Types
        {
            get { return types; }
            set { types = value; }
        }

        public static List<Gebruiker> Users
        {
            get { return gebruikers; }
            set { gebruikers = value; }
        }

        public static Databasemanager Database
        {
            get { return database; }
            set { database = value; }
        }
        #endregion

        #region constructor
        static Organizer()
        {
            GetData();
        }

        /// <summary>
        /// Gets all the necessary data and loads them into the lists.
        /// </summary>
        public static void GetData()
        {
            database = new Databasemanager();
            database.SetConnectionString("dbi307298", "DB06vwr6R2", "192.168.15.50:1521", "fhictora");
            //database.SetConnectionString("system", "system", "127.0.0.1", "xe");
            types = GetTypes();
            pokémons = GetPokémons();
            //types = GetTypes();
            gebruikers = GetGebruikers();
        }

        public static List<PokémonType> GetTypes()
        {
            return database.SelectTypes();
        }

        public static List<Pokémon> GetPokémons()
        {
            return database.SelectPokémons();
        }

        public static List<Gebruiker> GetGebruikers()
        {
            return database.SelectGebruikers();
        }
        #endregion
    }
}
