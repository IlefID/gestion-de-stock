using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class adminConnexion : Form
    {
        List<article1> listeArticle = new List<article1>();

        public adminConnexion()
        {
            InitializeComponent();
        }

        private void adminConnexion_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = listeArticle;
            dataGridView1.DataSource = bindingSource1;
            comboBoxCategories.DataSource = CategorieManager.GetCategories();
            comboBoxCategories.DisplayMember = "categorie";
            comboBoxCategories.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nom.Text) || string.IsNullOrEmpty(quantite.Text) || string.IsNullOrEmpty(prix.Text))
            {
                MessageBox.Show("Veuillez renseigner tous les champs : article, quantité et prix de l'article.");
            }
            else
            {
                try
                {
                    int quantiteInt = int.Parse(quantite.Text);
                    float prixFloat = float.Parse(prix.Text);
                    List<categorie1> selectedCategories = new List<categorie1> { (categorie1)comboBoxCategories.SelectedItem };
                    article1 art = new article1(nom.Text, quantiteInt, prixFloat, selectedCategories);

                    // Ajouter l'article à la base de données
                    ArticleManager.AjouterArticle(art);

                    listeArticle.Add(art);
                    bindingSource1.ResetBindings(false);
                    nom.Text = "";
                    quantite.Text = "";
                    prix.Text = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les champs quantité et prix.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer cet article ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int i = this.dataGridView1.CurrentRow.Index;
                    int articleID = (int)this.dataGridView1.Rows[i].Cells[0].Value; // Assuming ID is the first column

                    // Supprimer l'article de la base de données
                    ArticleManager.SupprimerArticle(articleID);

                    this.dataGridView1.Rows.RemoveAt(i);
                    listeArticle.RemoveAt(i);
                    bindingSource1.ResetBindings(false);
                    MessageBox.Show("L'article a été supprimé avec succès");
                }
                else
                {
                    MessageBox.Show("La suppression est annulée");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La liste des articles est vide ou une erreur s'est produite");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridView1.CurrentRow.Index;
                DataGridViewRow newdata = dataGridView1.Rows[a];

                int articleID = (int)newdata.Cells[0].Value; // Assuming ID is the first column
                int quantiteInt = int.Parse(quantite.Text);
                float prixFloat = float.Parse(prix.Text);
                List<categorie1> selectedCategories = new List<categorie1> { (categorie1)comboBoxCategories.SelectedItem };
                article1 nouvelArticle = new article1(nom.Text, quantiteInt, prixFloat, selectedCategories);

                // Modifier l'article dans la base de données
                ArticleManager.ModifierArticle(articleID, nouvelArticle);

                newdata.Cells[1].Value = nom.Text;
                newdata.Cells[2].Value = quantite.Text;
                newdata.Cells[3].Value = prix.Text;
                newdata.Cells[4].Value = selectedCategories;

                listeArticle[a] = nouvelArticle;
                bindingSource1.ResetBindings(false);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les champs quantité et prix.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[a];
            nom.Text = row.Cells[1].Value.ToString();
            quantite.Text = row.Cells[2].Value.ToString();
            prix.Text = row.Cells[3].Value.ToString();
            // Assuming Categories column index is 4 and is of type List<categorie1>
            var categories = (List<categorie1>)row.Cells[4].Value;
            if (categories != null && categories.Any())
            {
                comboBoxCategories.SelectedItem = categories.First();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            (new fournisseur()).Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label11_Click(object sender, EventArgs e)
        {
            (new Clients()).Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quantite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
