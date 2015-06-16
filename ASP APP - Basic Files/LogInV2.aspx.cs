using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_APP___Class_Library.Classes;
using ASP_APP___Class_Library;

namespace ASP_APP___Basic_Files
{
    public partial class LogInV2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            LogInAsAdmin();
        }

        /// <summary>
        /// Used to log in as an Admin, which then gets forwarded to the Create/Update/Delete Pages Menu.
        /// creates a session if correct.
        /// </summary>
        private void LogInAsAdmin()
        {
            foreach (Gebruiker g in Organizer.GetGebruikers())
            {
                if (g.Function.Equals("ADMINISTRATOR") && g.Wachtwoord == (Password.Text).ToUpper() && g.Emailadres == (Emailadres.Text).ToUpper())
                {
                    Session["USER_ID"] = g.Gebruikersnaam;
                    Response.Redirect("AdminPriviliges.aspx");
                }
            }
        }
    }
}