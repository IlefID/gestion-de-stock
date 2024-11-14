using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace gestion_de_stock
{
    public static class ArticleManager
    {
        public static void AjouterArticle(article1 article)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "INSERT INTO Article (Nom, Quantite, Prix) OUTPUT INSERTED.ID VALUES (@Nom, @Quantite, @Prix)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", article.nom);
                command.Parameters.AddWithValue("@Quantite", article.quantite);
                command.Parameters.AddWithValue("@Prix", article.prix);

                connection.Open();
                int articleID = (int)command.ExecuteScalar();

                foreach (var categorie in article.Categories)
                {
                    string queryCategorie = "INSERT INTO ArticleCategorie (ArticleID, CategorieID) VALUES (@ArticleID, @CategorieID)";
                    SqlCommand commandCategorie = new SqlCommand(queryCategorie, connection);
                    commandCategorie.Parameters.AddWithValue("@ArticleID", articleID);
                    commandCategorie.Parameters.AddWithValue("@CategorieID", categorie.ID);

                    commandCategorie.ExecuteNonQuery();
                }
            }
        }

        public static void ModifierArticle(int articleID, article1 nouvelArticle)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "UPDATE Article SET Nom = @Nom, Quantite = @Quantite, Prix = @Prix WHERE ID = @ArticleID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", nouvelArticle.nom);
                command.Parameters.AddWithValue("@Quantite", nouvelArticle.quantite);
                command.Parameters.AddWithValue("@Prix", nouvelArticle.prix);
                command.Parameters.AddWithValue("@ArticleID", articleID);

                connection.Open();
                command.ExecuteNonQuery();

                string deleteQuery = "DELETE FROM ArticleCategorie WHERE ArticleID = @ArticleID";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ArticleID", articleID);
                deleteCommand.ExecuteNonQuery();

                foreach (var categorie in nouvelArticle.Categories)
                {
                    string queryCategorie = "INSERT INTO ArticleCategorie (ArticleID, CategorieID) VALUES (@ArticleID, @CategorieID)";
                    SqlCommand commandCategorie = new SqlCommand(queryCategorie, connection);
                    commandCategorie.Parameters.AddWithValue("@ArticleID", articleID);
                    commandCategorie.Parameters.AddWithValue("@CategorieID", categorie.ID);

                    commandCategorie.ExecuteNonQuery();
                }
            }
        }

        public static void SupprimerArticle(int articleID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "DELETE FROM ArticleCategorie WHERE ArticleID = @ArticleID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ArticleID", articleID);

                connection.Open();
                command.ExecuteNonQuery();

                string deleteArticleQuery = "DELETE FROM Article WHERE ID = @ArticleID";
                SqlCommand deleteArticleCommand = new SqlCommand(deleteArticleQuery, connection);
                deleteArticleCommand.Parameters.AddWithValue("@ArticleID", articleID);
                deleteArticleCommand.ExecuteNonQuery();
            }
        }

        public static article1 GetArticle(int articleID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = @"
                    SELECT a.ID, a.Nom, a.Quantite, a.Prix, c.ID as CategorieID, c.Nom as CategorieNom
                    FROM Article a
                    LEFT JOIN ArticleCategorie ac ON a.ID = ac.ArticleID
                    LEFT JOIN Categorie c ON ac.CategorieID = c.ID
                    WHERE a.ID = @ArticleID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ArticleID", articleID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                article1 article = null;
                List<categorie1> categories = new List<categorie1>();

                while (reader.Read())
                {
                    if (article == null)
                    {
                        article = new article1(
                            reader.GetInt32(reader.GetOrdinal("ID")),
                            reader.GetString(reader.GetOrdinal("Nom")),
                            reader.GetInt32(reader.GetOrdinal("Quantite")),
                            reader.GetFloat(reader.GetOrdinal("Prix")),
                            categories
                        );
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("CategorieID")))
                    {
                        categories.Add(new categorie1(
                            reader.GetInt32(reader.GetOrdinal("CategorieID")),
                            reader.GetString(reader.GetOrdinal("CategorieNom"))
                        ));
                    }
                }

                return article;
            }
        }
    }
}
