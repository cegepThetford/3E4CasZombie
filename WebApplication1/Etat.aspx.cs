using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zombie_Affaires;

namespace WebApplication1
{
    public partial class Etat : System.Web.UI.Page
    {
        public Creature creature;

        protected void Page_Load(object sender, EventArgs e)
        {
            creature = (Creature)Application["marco"];
        }
    }
}