using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using ASP_APP___Class_Library.Classes;

namespace ASP_APP___Class_Library
{
    public class Databasemanager
    {
        #region Fields
        private static OracleConnection conn = new OracleConnection();
        #endregion

        #region Properties
        private static OracleConnection Conn { get { return conn; } set { conn = value; } }
        #endregion

        #region Standard Oracle communication Methods
        /// <summary>
        /// Set the connectionstring with which to connect to the database.
        /// </summary>
        public void SetConnectionString(string username, string password, string address, string serviceName)
        {
            conn.ConnectionString = "User Id=" + username + "; Password=" + password + "; Data Source=//" + address + "/" + serviceName + "; Connection Timeout=5; Pooling=true; Statement Cache Size=10;";
            try
            {
                Connect();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Opens the database connection using the connectionstring that has been made in the constructor
        /// </summary>
        /// <returns>Returns a bool to return if the operation was succesfull</returns>
        private bool Connect()
        {
            try
            {
                conn.Open();
            }
            catch (OracleException e)
            {
                System.Diagnostics.Debug.Write("");
                System.Diagnostics.Debug.Write("Er is een fout opgetreden tijdens de communicatie met de database.");
                System.Diagnostics.Debug.Write("");
                System.Diagnostics.Debug.Write(e.Message);
                System.Diagnostics.Debug.Write("");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        /// <returns>Returns a bool to return if the operation was succesfull</returns>
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (OracleException)
            {
            }
            return true;
        }

        /// <summary>
        /// Executes a query
        /// </summary>
        /// <param name="query">The query to execute </param>
        /// <returns>A datatabel containing the output from the datbase</returns>
        private DataTable ExecuteQuery(string query)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable outputTable = new DataTable();

            if (!Connect())
            {
                return null;
            }

            try
            {
                OracleDataReader odr = cmd.ExecuteReader();
                outputTable.Load(odr);
            }
            catch (NullReferenceException)
            {
                CloseConnection();
                return null;
            }
            catch (OracleException e)
            {
                System.Diagnostics.Debug.Write("");
                System.Diagnostics.Debug.Write("Er is een fout opgetreden tijdens de communicatie met de database." + query + " - " + e.Message);
                System.Diagnostics.Debug.Write("");
                System.Diagnostics.Debug.Write(e.Message);
                System.Diagnostics.Debug.Write("");
            }
            CloseConnection();
            return outputTable;
        }

        private DataTable Select(string type, string[] values, string where)
        {
            string query = "SELECT ";
            for (int i = 0; i < values.Length; i++)
            {
                if (i != values.Length - 1)
                {
                    query += values[i] + ",";
                }
                else
                {
                    query += values[i];
                }
            }
            query = query + " FROM " + type;
            if (where != null)
            {
                query += " WHERE " + where;
            }
            return ExecuteQuery(query);
        }

        private DataTable Insert(string type, string[] values)
        {
            int output = Int32.MinValue;
            string query = "INSERT INTO " + type + " VALUES(";
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == null)
                {
                    if (values.Length - 1 != i)
                    {
                        query += "NULL, ";
                    }
                    else
                    {
                        query += "NULL)";
                    }
                }
                else if (Int32.TryParse(values[i], out output))
                {
                    if (values.Length - 1 != i)
                    {
                        query += values[i] + ", ";
                    }
                    else
                    {
                        query += values[i] + ")";
                    }
                }
                else if (!(values[i].Contains("-") || values[i].Contains("/")))
                {
                    if (values.Length - 1 != i)
                    {
                        query += "'" + values[i] + "', ";
                    }
                    else
                    {
                        query += "'" + values[i] + "')";
                    }
                }
                else if (values[i].Contains("-") || values[i].Contains("/"))
                {
                    if (values[i].Contains("-"))
                    {
                        if (values.Length - 1 != i)
                        {
                            query += "TO_DATE('" + values[i] + "', 'DD/MM/YYYY'), ";
                        }
                        else
                        {
                            query += "TO_DATE('" + values[i] + "', 'DD/MM/YYYY'))";
                        }
                    }
                    else if (values[i].Contains("/"))
                    {
                        if (values.Length - 1 != i)
                        {
                            query += "TO_DATE('" + values[i] + "', 'DD/MM/YYYY'), ";
                        }
                        else
                        {
                            query += "TO_DATE('" + values[i] + "', 'DD/MM/YYYY'))";
                        }
                    }
                }
            }
            return ExecuteQuery(query);
        }

        private DataTable Remove(string type, string column, string value)
        {
            string query = "DELETE FROM " + type + " WHERE " + column + " = ";
            int output = Int32.MinValue;
            if (Int32.TryParse(value, out output))
            {
                query += value;
            }
            else
            {
                query += "'" + value + "'";
            }
            return ExecuteQuery(query);
        }

        private DataTable Update(string type, string checkColumn, string checkValue, string updateColumn, string updateValue)
        {
            string query = "UPDATE " + type + " SET " + updateColumn + " = '";
            int output = Int32.MinValue;
            if (Int32.TryParse(checkValue, out output))
            {
                query += updateValue + "' WHERE " + checkColumn + " = '" + checkValue + "'";
            }
            else
            {
                query += "'" + updateValue + "'" + " WHERE " + checkColumn + " = " + "'" + checkValue + "'";
            }
            return ExecuteQuery(query);
        }

        private DataTable SelectAllColumns(string tablename)
        {
            string[] values = new string[1];
            values[0] = "*";
            return Select(tablename, values, null);
        }
        #endregion

        #region App-Specific Methods
        public List<Pokémon> SelectPokémons()
        {
            DataTable data = SelectAllColumns("POKEMON");

            List<Pokémon> pokémons = new List<Pokémon>();

            foreach (DataRow r in data.Rows)
            {
                pokémons.Add(DRConverter.ToPokémon(r));
            }

            return pokémons;
        }

        public List<PokémonType> SelectTypes()
        {
            DataTable data = SelectAllColumns("TYPE");

            List<PokémonType> pokémonTypes = new List<PokémonType>();

            foreach (DataRow r in data.Rows)
            {
                pokémonTypes.Add(DRConverter.ToType(r));
            }

            return pokémonTypes;

        }

        public List<Gebruiker> SelectGebruikers()
        {
            DataTable data = SelectAllColumns("GEBRUIKER");

            List<Gebruiker> users = new List<Gebruiker>();

            foreach (DataRow r in data.Rows)
            {
                users.Add(DRConverter.ToUser(r));
            }

            return users;
        }
        #endregion
    }
}
