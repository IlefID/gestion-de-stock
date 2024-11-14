using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public class Client
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Pays { get; set; }

        public Client(int id, string nom, string prenom, string adresse, string ville, string telephone, string pays)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Ville = ville;
            Telephone = telephone;
            Pays = pays;
        }
    }
}
