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
    public partial class AdminPriviliges : System.Web.UI.Page
    {
        bool loggedIn = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER_ID"] != null)
            {
                foreach (Gebruiker g in Organizer.GetGebruikers())
                {
                    if (Session["USER_ID"].ToString() == g.Gebruikersnaam)
                    {
                        loggedIn = true;
                        UserNameLabel.Text = g.Gebruikersnaam;
                    }
                }
            }

            CheckLoggedIn();
        }

        private void CheckLoggedIn()
        {
            if(loggedIn)
            {
                
            }
            else
            {

            }
        }
    }
}