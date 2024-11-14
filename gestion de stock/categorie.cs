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
    public partial class categorie : Form
    {
        public categorie()
        {
            InitializeComponent();
        }

        private void categorie_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CategorieManager.GetCategories();
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textcat.Text))
            {
                MessageBox.Show("Entrez une catégorie !");
            }
            else
            {
                var cat = new categorie1(textcat.Text);
                CategorieManager.AjouterCategorie(cat);
                bindingSource1.DataSource = CategorieManager.GetCategories();
                bindingSource1.ResetBindings(false);
                textcat.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer cette catégorie ?!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int i = this.dataGridView1.CurrentRow.Index;
                    var cat = CategorieManager.GetCategories()[i];
                    CategorieManager.SupprimerCategorie(i);
                    bindingSource1.DataSource = CategorieManager.GetCategories();
                    bindingSource1.ResetBindings(false);
                    MessageBox.Show("La catégorie a été supprimée avec succès");
                }
                else
                {
                    MessageBox.Show("La suppression est annulée");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La liste de catégories est vide");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            DataGridViewRow newdata = dataGridView1.Rows[a];
            var cat = CategorieManager.GetCategories()[a];
            cat.categorie = textcat.Text;
            CategorieManager.ModifierCategorie(a, cat);
            bindingSource1.DataSource = CategorieManager.GetCategories();
            bindingSource1.ResetBindings(false);
            newdata.Cells[0].Value = textcat.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            (new adminConnexion()).Show();
            this.Hide();
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

        private void label13_Click(object sender, EventArgs e)
        {
            (new Clients()).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[a];
            textcat.Text = row.Cells[0].Value.ToString();
        }
    }
}
