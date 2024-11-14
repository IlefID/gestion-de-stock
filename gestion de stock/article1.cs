using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public class article1
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public int quantite { get; set; }
        public float prix { get; set; }
        public List<categorie1> Categories { get; set; }

        public article1(string n, int q, float p, List<categorie1> cats)
        {
            nom = n;
            quantite = q;
            prix = p;
            Categories = cats;
        }

        public article1(int id, string n, int q, float p, List<categorie1> cats)
        {
            ID = id;
            nom = n;
            quantite = q;
            prix = p;
            Categories = cats;
        }

        public void AjouterCategorie(categorie1 cat)
        {
            Categories.Add(cat);
        }

        public void RetirerCategorie(categorie1 cat)
        {
            Categories.Remove(cat);
        }
    }
}
