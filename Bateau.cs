using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appli_groupe
{
    class Bateau
    {
        private string nom;
        private double longueur;
        private double largeur;
        private double vitesse;
        private int nbPassagers;
        private int nbVoitures;
        private DateTime dateProchaineVisite;

        public Bateau(string unNom, double uneLongueur, double uneLargeur, double uneVitesse, int unNbP, int unNbV)
        {
            nom = unNom;
            longueur = uneLongueur;
            largeur = uneLargeur;
            vitesse = uneVitesse;
            nbPassagers = unNbP;
            nbVoitures = unNbV;
            dateProchaineVisite = new DateTime();
        }

        public void setDateVisite(DateTime uneDate)
        {
            dateProchaineVisite = uneDate;
        }

        public String getNomBateau()
        {
            return this.nom;
        }

        public double getLongueur()
        {
            return this.longueur;
        }

        public double getLargeur()
        {
            return this.largeur;
        }
        public double getVitesse()
        {
            return this.vitesse;
        }

        public int getNbPassagers()
        {
            return this.nbPassagers;
        }

        public int getNbVoitures()
        {
            return this.nbVoitures;
        }

        public DateTime getDateVisite()
        {
            return this.dateProchaineVisite;
        }

    }
}
