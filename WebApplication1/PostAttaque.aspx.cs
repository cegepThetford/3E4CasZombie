using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zombie_Affaires;

namespace WebApplication1
{
    public partial class PostAttaque : System.Web.UI.Page
    {
        public int nbDommages;
        public Creature creature;
        public Arme arme;
        public DeCombat de;


        protected void Page_Load(object sender, EventArgs e)
        {
            creature = (Creature)Application["marco"];
            nbDommages = (int) Application["nbDommages"];
            arme = (Arme)Application["arme"];
            de = DeJeu.getInstance().De;
        }

        public bool valider() { return true; }
    }
}