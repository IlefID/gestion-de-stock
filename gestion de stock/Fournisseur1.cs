using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public class Fournisseur1
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Fournisseur1(int id, string nom, string prenom, string adresse, string email, string telephone)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Email = email;
            Telephone = telephone;
        }
    }
}
