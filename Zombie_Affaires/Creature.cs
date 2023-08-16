using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie_Affaires
{
    public abstract class Creature
    {
        protected int _nbPtsVie;

        public Creature(int nbPtsVie)
        {
            _nbPtsVie = nbPtsVie;
        }

        public int NbPtsVie { get { return _nbPtsVie; } set { _nbPtsVie = value; }}

        public void enregistrerDegats(int nbPts)
        {
            // Completer
            // Cette methode diminue le nombre de points de vie de la creature
            // On ramene a zero si le nombre de points de vie devient negatif.
 
        }

        public bool estMorte() 
        {
            // Completer
            // Permet de savoir si la creature est morte (aucun point de vie)
            return false;
        }
        public bool estVivante() 
        { 
            return !this.estMorte(); 
        }

        public virtual int attaquer(Arme arme)
        {
            int dommages = this.determinerDommagesEffectifs(arme);
            this.enregistrerDegats(dommages);
            return dommages;
        }

        public virtual int determinerDommagesEffectifs(Arme arme)
        {
            DeCombat de = DeJeu.getInstance().De;
            int ptsDegat = 0;
            // Completer
            // On lance le de
            // 0 points de degat si on manque
            // dommages max de l'arme si attaque critique
            // pour une attaque normale
            //    demande a l'arme de determiner les dommages a infliger (nb points de degat)

            return ptsDegat;
        }
    }
}
