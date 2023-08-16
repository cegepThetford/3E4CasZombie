using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zombie_Affaires;

namespace WebApplication1
{
    public class FacadeJeu
    {
        public static Creature genererNouvelleCreature()
        {
            return new Zombie(22);
        }
    }

}