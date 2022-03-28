using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appli_groupe
{
    class Billet
    {
        public string nomClient;
        public int nbPassagers;
        public int nbVehicules;
        public double montant;
        public Traversee laTraversee;

        // constructeur qui valorise tous les attributs de l'objet
        public Billet(string unNom, int unNbP, int unNbV, double unMontant, Traversee uneTraversee)
        {
            nomClient = unNom;
            nbPassagers = unNbP;
            nbVehicules = unNbV;
            montant = unMontant;
            laTraversee = uneTraversee;
        }

        public string getNomClient()
        {
            return nomClient;
        }

        public int getNbPassagers()
        {
            return nbPassagers;
        }

        public int getNbVehicules()
        {
            return nbVehicules;
        }

        public double getMontantTotal()
        {
            return montant;
        }

        public Traversee getTraversee()
        {
            return laTraversee;
        }

    }
}
