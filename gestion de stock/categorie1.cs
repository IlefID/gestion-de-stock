using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public class categorie1
    {
        public int ID { get; set; } 
        public string categorie { get; set; }

        public categorie1(int id, string cat)
        {
            ID = id;
            categorie = cat;
        }

        public override string ToString()
        {
            return categorie;
        }
    }
}
