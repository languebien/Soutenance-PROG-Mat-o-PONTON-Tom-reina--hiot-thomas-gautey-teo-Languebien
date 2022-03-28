﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appli_groupe

{
    class Traversee
    {
        private int numero;
        private DateTime dateDepart;
        private int duree;
        private int nbPassagers;
        private int nbVehicules;
        private Bateau leBateau;
        private Port lePortDepart;
        private Port lePortArrivee;

        public Traversee(int unNumero, DateTime uneDate,int uneDuree, Port unPortDep,Port unPortArr)
        {
            numero = unNumero;
            dateDepart = uneDate;
            duree = uneDuree;
            nbPassagers = 0;
            nbVehicules = 0;
            lePortArrivee = unPortArr;
            lePortDepart = unPortDep;

        }

        public int getNumerp()
        {
            return numero;
        }

        public DateTime getDateDepart()
        {
            return dateDepart;
        }

        public int getDuree()
        {
            return duree;
        }

        public Port getPortDepart()
        {
            return lePortDepart;
        }

        public Port getPortArrivee()
        {
            return lePortArrivee;
        }
        public void setnbPassagers(int unNbP)
        {
            nbPassagers = unNbP;
        }

        public void setNbVehicules(int unNbV)
        {
            nbVehicules = unNbV;
        }

        public void setBateau(Bateau unBateau)
        {
            leBateau=unBateau;
        }

    }
}
