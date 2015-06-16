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
    public partial class Pokédex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(Pokémon p in Organizer.Pokémons)
            {
                if(p.PokédexNr <= 151)
                {
                    Pokémon151.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }

                if (p.PokédexNr <= 251 && p.PokédexNr > 151)
                {
                    Pokémon251.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }

                if (p.PokédexNr <= 386 && p.PokédexNr > 251)
                {
                    Pokémon386.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }

                if (p.PokédexNr <= 468 && p.PokédexNr > 386)
                {
                    Pokémon468.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }

                if (p.PokédexNr <= 649 && p.PokédexNr > 468)
                {
                    Pokémon649.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }

                if (p.PokédexNr <= 720 && p.PokédexNr > 649)
                {
                    Pokémon720.Items.Add("#" + p.PokédexNr + " - " + p.Naam);
                }


                
            }
        }
    }
}