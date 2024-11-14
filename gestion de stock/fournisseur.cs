using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class fournisseur : Form
    {
        List<Fournisseur1> listeFournisseur = new List<Fournisseur1>();

        public fournisseur()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(prenom.Text) ||
                string.IsNullOrWhiteSpace(adresse.Text) || string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(telephone.Text))
            {
                MessageBox.Show("Entrez les coordonnées du fournisseur !");
            }
            else
            {
                Fournisseur1 f = new Fournisseur1(0, nom.Text, prenom.Text, adresse.Text, email.Text, telephone.Text);
                FournisseurManager.AjouterFournisseur(f);
                LoadFournisseurs();

                nom.Text = "";
                prenom.Text = "";
                adresse.Text = "";
                email.Text = "";
                telephone.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer ce fournisseur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int i = this.dataGridView1.CurrentRow.Index;
                    int fournisseurID = (int)dataGridView1.Rows[i].Cells[5].Value; // Assuming the ID column is hidden and at index 5
                    FournisseurManager.SupprimerFournisseur(fournisseurID);
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Le fournisseur a été supprimé avec succès");
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

        private void fournisseur_Load(object sender, EventArgs e)
        {
            LoadFournisseurs();
        }

        private void LoadFournisseurs()
        {
            listeFournisseur = FournisseurManager.GetAllFournisseurs();
            bindingSource1.DataSource = listeFournisseur;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nom.Text = row.Cells[0].Value.ToString();
                prenom.Text = row.Cells[1].Value.ToString();
                adresse.Text = row.Cells[2].Value.ToString();
                email.Text = row.Cells[3].Value.ToString();
                telephone.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int fournisseurID = (int)row.Cells[5].Value; // Assuming the ID column is hidden and at index 5
                Fournisseur1 updatedFournisseur = new Fournisseur1(
                    fournisseurID,
                    nom.Text,
                    prenom.Text,
                    adresse.Text,
                    email.Text,
                    telephone.Text
                );

                FournisseurManager.ModifierFournisseur(fournisseurID, updatedFournisseur);
                LoadFournisseurs();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            (new adminConnexion()).Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            (new Clients()).Show();
            this.Hide();
        }
    }
}
