using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class livirason : Form
    {
        List<Livraison> listeLivraison = new List<Livraison>();

        public livirason()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void livirason_Load(object sender, EventArgs e)
        {
            LoadLivraisons();
        }

        private void LoadLivraisons()
        {
            listeLivraison = LivraisonManager.GetAllLivraisons();
            bindingSource1.DataSource = listeLivraison;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(article.Text) || string.IsNullOrWhiteSpace(quantite.Text) || string.IsNullOrWhiteSpace(date.Text))
            {
                MessageBox.Show("Veuillez renseigner tous les champs : article, quantité et date de livraison.");
            }
            else
            {
                try
                {
                    int quantiteInt = int.Parse(quantite.Text);
                    DateTime dateValue = DateTime.Parse(date.Text);

                    Livraison livraison = new Livraison(int.Parse(article.Text), quantiteInt, dateValue); // assuming ArticleID is an integer
                    LivraisonManager.AjouterLivraison(livraison);
                    LoadLivraisons();

                    article.Text = "";
                    quantite.Text = "";
                    date.Text = "";
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les champs quantité et date.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer cette livraison ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int i = this.dataGridView1.CurrentRow.Index;
                    int livraisonID = (int)dataGridView1.Rows[i].Cells[3].Value; 
                    LivraisonManager.SupprimerLivraison(livraisonID);
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("La livraison a été supprimée avec succès");
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

        int selectedRowIndex;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                article.Text = row.Cells[0].Value.ToString();
                quantite.Text = row.Cells[1].Value.ToString();
                date.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int quantiteInt = int.Parse(quantite.Text);
                    DateTime dateValue = DateTime.Parse(date.Text);

                    DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                    int livraisonID = (int)row.Cells[3].Value; 

                    Livraison livraison = new Livraison
                    {
                        ID = livraisonID,
                        ArticleID = int.Parse(article.Text),
                        Quantite = quantiteInt,
                        DateLivraison = dateValue
                    };

                    LivraisonManager.ModifierLivraison(livraisonID, livraison);
                    LoadLivraisons();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les champs quantité et date.");
                }
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

        private void article_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
