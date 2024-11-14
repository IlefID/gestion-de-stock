using System.Collections.Generic;
using System.Data.SqlClient;

namespace gestion_de_stock
{
    public static class LivraisonManager
    {
        public static void AjouterLivraison(Livraison livraison)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "INSERT INTO Livraison (ArticleID, Quantite, DateLivraison) VALUES (@ArticleID, @Quantite, @DateLivraison)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ArticleID", livraison.ArticleID);
                command.Parameters.AddWithValue("@Quantite", livraison.Quantite);
                command.Parameters.AddWithValue("@DateLivraison", livraison.DateLivraison);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ModifierLivraison(int livraisonID, Livraison nouvelleLivraison)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "UPDATE Livraison SET ArticleID = @ArticleID, Quantite = @Quantite, DateLivraison = @DateLivraison WHERE ID = @LivraisonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ArticleID", nouvelleLivraison.ArticleID);
                command.Parameters.AddWithValue("@Quantite", nouvelleLivraison.Quantite);
                command.Parameters.AddWithValue("@DateLivraison", nouvelleLivraison.DateLivraison);
                command.Parameters.AddWithValue("@LivraisonID", livraisonID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void SupprimerLivraison(int livraisonID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "DELETE FROM Livraison WHERE ID = @LivraisonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LivraisonID", livraisonID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<Livraison> GetAllLivraisons()
        {
            List<Livraison> livraisons = new List<Livraison>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT * FROM Livraison";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Livraison livraison = new Livraison
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        ArticleID = reader.GetInt32(reader.GetOrdinal("ArticleID")),
                        Quantite = reader.GetInt32(reader.GetOrdinal("Quantite")),
                        DateLivraison = reader.GetDateTime(reader.GetOrdinal("DateLivraison"))
                    };

                    livraisons.Add(livraison);
                }
            }

            return livraisons;
        }
    }
}
