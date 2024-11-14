using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public static class ClientManager
    {
        public static void AjouterClient(Client client)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "INSERT INTO Client (Nom, Prenom, Adresse, Ville, Telephone, Pays) VALUES (@Nom, @Prenom, @Adresse, @Ville, @Telephone, @Pays)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", client.Nom);
                command.Parameters.AddWithValue("@Prenom", client.Prenom);
                command.Parameters.AddWithValue("@Adresse", client.Adresse);
                command.Parameters.AddWithValue("@Ville", client.Ville);
                command.Parameters.AddWithValue("@Telephone", client.Telephone);
                command.Parameters.AddWithValue("@Pays", client.Pays);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ModifierClient(int clientID, Client nouveauClient)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "UPDATE Client SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Ville = @Ville, Telephone = @Telephone, Pays = @Pays WHERE ID = @ClientID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", nouveauClient.Nom);
                command.Parameters.AddWithValue("@Prenom", nouveauClient.Prenom);
                command.Parameters.AddWithValue("@Adresse", nouveauClient.Adresse);
                command.Parameters.AddWithValue("@Ville", nouveauClient.Ville);
                command.Parameters.AddWithValue("@Telephone", nouveauClient.Telephone);
                command.Parameters.AddWithValue("@Pays", nouveauClient.Pays);
                command.Parameters.AddWithValue("@ClientID", clientID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void SupprimerClient(int clientID)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "DELETE FROM Client WHERE ID = @ClientID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", clientID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT * FROM Client";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Client client = new Client(
                        reader.GetInt32(reader.GetOrdinal("ID")),
                        reader.GetString(reader.GetOrdinal("Nom")),
                        reader.GetString(reader.GetOrdinal("Prenom")),
                        reader.GetString(reader.GetOrdinal("Adresse")),
                        reader.GetString(reader.GetOrdinal("Ville")),
                        reader.GetString(reader.GetOrdinal("Telephone")),
                        reader.GetString(reader.GetOrdinal("Pays"))
                    );

                    clients.Add(client);
                }
            }

            return clients;
        }
    }
}
