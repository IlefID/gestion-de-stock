using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class Clients : Form
    {
        List<Client> listeClient = new List<Client>();

        public Clients()
        {
            InitializeComponent();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            (new Clients()).Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            (new adminConnexion()).Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            (new fournisseur()).Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            (new categorie()).Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            (new livirason()).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nom.Text = row.Cells[0].Value.ToString();
                prenom.Text = row.Cells[1].Value.ToString();
                adresse.Text = row.Cells[2].Value.ToString();
                ville.Text = row.Cells[3].Value.ToString();
                telephone.Text = row.Cells[4].Value.ToString();
                pays.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int i = dataGridView1.CurrentRow.Index;
                    int clientID = (int)dataGridView1.Rows[i].Cells[6].Value;
                    ClientManager.SupprimerClient(clientID);
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Le client a été supprimé avec succès");
                }
                else
                {
                    MessageBox.Show("La suppression est ignorée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            listeClient = ClientManager.GetAllClients();
            bindingSource1.DataSource = listeClient;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int clientID = (int)row.Cells[6].Value;
                Client updatedClient = new Client(
                    clientID,
                    nom.Text,
                    prenom.Text,
                    adresse.Text,
                    ville.Text,
                    telephone.Text,
                    pays.Text
                );

                ClientManager.ModifierClient(clientID, updatedClient);
                LoadClients();
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(prenom.Text) ||
                string.IsNullOrWhiteSpace(adresse.Text) || string.IsNullOrWhiteSpace(ville.Text) ||
                string.IsNullOrWhiteSpace(telephone.Text) || string.IsNullOrWhiteSpace(pays.Text))
            {
                MessageBox.Show("Veuillez entrer toutes les coordonnées du client !");
            }
            else
            {
                Client newClient = new Client(
                    0,
                    nom.Text,
                    prenom.Text,
                    adresse.Text,
                    ville.Text,
                    telephone.Text,
                    pays.Text
                );

                ClientManager.AjouterClient(newClient);
                LoadClients();

                nom.Text = "";
                prenom.Text = "";
                adresse.Text = "";
                ville.Text = "";
                telephone.Text = "";
                pays.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
