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
            this.nom = unNom;
        }

        public String getNomPort()
        {
            return this.nom;
        }

        
    }
}
