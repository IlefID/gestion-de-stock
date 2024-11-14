using System.Collections.Generic;
using System.Data.SqlClient;

namespace gestion_de_stock
{
    public static class FournisseurManager
    {
        public static void AjouterFournisseur(Fournisseur1 fournisseur)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "INSERT INTO Fournisseur (Nom, Prenom, Adresse, Email, Telephone) VALUES (@Nom, @Prenom, @Adresse, @Email, @Telephone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", fournisseur.Nom);
                command.Parameters.AddWithValue("@Prenom", fournisseur.Prenom);
                command.Parameters.AddWithValue("@Adresse", fournisseur.Adresse);
                command.Parameters.AddWithValue("@Email", fournisseur.Email);
                command.Parameters.AddWithValue("@Telephone", fournisseur.Telephone);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ModifierFournisseur(int fournisseurID, Fournisseur1 nouveauFournisseur)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "UPDATE Fournisseur SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Email = @Email, Telephone = @Telephone WHERE ID = @FournisseurID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", nouveauFournisseur.Nom);
                command.Parameters.AddWithValue("@Prenom", nouveauFournisseur.Prenom);
                command.Parameters.AddWithValue("@Adresse", nouveauFournisseur.Adresse);
                command.Parameters.AddWithValue("@Email", nouveauFournisseur.Email);
                command.Parameters.AddWithValue("@Telephone", nouveauFournisseur.Telephone);
                command.Parameters.AddWithValue("@FournisseurID", fournisseurID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void SupprimerFournisseur(int fournisseurID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "DELETE FROM Fournisseur WHERE ID = @FournisseurID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FournisseurID", fournisseurID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<Fournisseur1> GetAllFournisseurs()
        {
            List<Fournisseur1> fournisseurs = new List<Fournisseur1>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT * FROM Fournisseur";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Fournisseur1 fournisseur = new Fournisseur1(
                        reader.GetInt32(reader.GetOrdinal("ID")),
                        reader.GetString(reader.GetOrdinal("Nom")),
                        reader.GetString(reader.GetOrdinal("Prenom")),
                        reader.GetString(reader.GetOrdinal("Adresse")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetString(reader.GetOrdinal("Telephone"))
                    );

                    fournisseurs.Add(fournisseur);
                }
            }

            return fournisseurs;
        }
    }
}
