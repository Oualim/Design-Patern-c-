using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    public class Utilisateur
    {
        private string _nom = "jjjj";
        private string _prenom;

        public string nom
        {
            get { return _nom; } // get permet de lire la valeur
            protected set { _nom = value; } // permet de modifier une valeur (ici protected donc pas modifiable)
        }
        
        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}
