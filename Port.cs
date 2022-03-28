using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appli_groupe
{
    class Port
    {
        private string nom;

        public Port(string unNom)
        {
            nom = unNom;
        }

        public string getNom()
        {
            return nom;
        }
    }
}
