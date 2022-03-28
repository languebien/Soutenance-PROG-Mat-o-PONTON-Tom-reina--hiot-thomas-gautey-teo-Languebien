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

        public string getNom()
        {
            return nom;
        }

        public double getLongueur()
        {
            return longueur;
        }

        public double getLargeur()
        {
            return largeur;
        }
        public double getVitesse()
        {
            return vitesse;
        }

        public int getNbPassagers()
        {
            return nbPassagers;
        }

        public int getNbVoitures()
        {
            return nbVoitures;
        }

        public DateTime getDateVisite()
        {
            return dateProchaineVisite;
        }

    }
}
