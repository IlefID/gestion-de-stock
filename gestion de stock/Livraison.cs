using System;

namespace gestion_de_stock
{
    public class Livraison
    {
        public int ID { get; set; }
        public int ArticleID { get; set; }
        public int Quantite { get; set; }
        public DateTime DateLivraison { get; set; }

        public Livraison()
        {
        }

        public Livraison(int articleID, int quantite, DateTime dateLivraison)
        {
            ArticleID = articleID;
            Quantite = quantite;
            DateLivraison = dateLivraison;
        }
    }
}
