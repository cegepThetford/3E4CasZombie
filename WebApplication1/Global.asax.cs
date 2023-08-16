using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Zombie_Affaires; 

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        private Creature _marco;
        private Dictionary<string,Arme> _armes;

        void Application_Start(object sender, EventArgs e)
        {
            
            // Code qui s'exécute au démarrage de l'application
            _marco = FacadeJeu.genererNouvelleCreature();
            Application["marco"] = _marco;
            _armes = new Dictionary<string, Arme>()
            {
                {"epee",new Arme("Épée en argent (5-10)", 5, 10, false, true, false) },
                {"baton",new Arme("Baton de baseball (3-7)", 3, 7, true, false, false) },
                {"lance",new Arme("Lance sacrée (4-9)", 4, 9, false, false, true) },
                {"cureDent",new Arme("Cure-dent béni en argent (1-2)", 1, 2, false, true, true) }
            };
            Application["armes"] = _armes;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code qui s'exécute à l'arrêt de l'application

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code qui s'exécute lorsqu'une erreur non gérée se produit

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code qui s'exécute lorsqu'une nouvelle session démarre

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code qui s'exécute lorsqu'une session se termine. 
            // Remarque : l'événement Session_End est déclenché uniquement lorsque le mode sessionstate
            // a la valeur InProc dans le fichier Web.config. Si le mode de session a la valeur StateServer 
            // ou SQLServer, l'événement n'est pas déclenché.

        }

    }
}
