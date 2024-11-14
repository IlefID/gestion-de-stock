using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public static class CategorieManager
    {
        public static void AjouterCategorie(categorie1 categorie)
        {
            try
            {
                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    string query = "INSERT INTO Categorie (Nom) VALUES (@Nom)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nom", categorie.categorie);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}");
            }
        }

        public static void ModifierCategorie(int categorieID, categorie1 nouvelleCategorie)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "UPDATE Categorie SET Nom = @Nom WHERE ID = @CategorieID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", nouvelleCategorie.categorie);
                command.Parameters.AddWithValue("@CategorieID", categorieID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void SupprimerCategorie(int categorieID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "DELETE FROM Categorie WHERE ID = @CategorieID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategorieID", categorieID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<categorie1> GetCategories()
        {
            List<categorie1> categories = new List<categorie1>();
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT ID, Nom FROM Categorie";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new categorie1((int)reader["ID"], reader["Nom"].ToString()));
                }
            }
            return categories;
        }
    }
}

