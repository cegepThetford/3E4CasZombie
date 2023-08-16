using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zombie_Affaires;

namespace WebApplication1
{
    public partial class Attaquer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Creature c = (Creature)Application["marco"];
                if (c.estMorte())
                    Response.Redirect("/mort.aspx");

                Dictionary<string, Arme> armes;
                armes = (Dictionary<string, Arme>)Application["armes"];
                rblArmes.Items.Clear();
                foreach (string cle in armes.Keys)
                {
                    ListItem item = new ListItem();
                    item.Text = armes[cle].Nom;
                    item.Value = cle;
                    rblArmes.Items.Add(item);
                }
                if (rblArmes.Items.Count > 0)
                    rblArmes.Items[0].Selected = true;
            }
        }

        protected void btnAttaquer_Click(object sender, EventArgs e)
        {
            Dictionary<string, Arme> armes;
            armes = (Dictionary<string, Arme>)Application["armes"];
            Creature c = (Creature)Application["marco"];
            Arme arme = armes[rblArmes.SelectedValue];
            int nbDommages = arme.attaquer(c);
            Application["nbDommages"] = nbDommages;
            Application["arme"] = arme;
            Response.Redirect("PostAttaque.aspx");
        }

    }
}