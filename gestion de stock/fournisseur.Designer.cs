using System;

namespace gestion_de_stock
{
    partial class fournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Location = new System.Drawing.Point(178, 860);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 54);
            this.button3.TabIndex = 58;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(101, 920);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 54);
            this.button2.TabIndex = 57;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.LimeGreen;
            this.ajouter.Location = new System.Drawing.Point(19, 860);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(140, 54);
            this.ajouter.TabIndex = 56;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 847);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 53;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(22, 589);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(245, 35);
            this.adresse.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 29);
            this.label9.TabIndex = 49;
            this.label9.Text = "Adresse :";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(22, 472);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(245, 35);
            this.prenom.TabIndex = 48;
            this.prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 29);
            this.label8.TabIndex = 47;
            this.label8.Text = "Prenom Du Fournisseur:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(22, 372);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(238, 35);
            this.nom.TabIndex = 46;
            this.nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nom Du Fournisseur:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(1213, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Deconnection";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(998, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "Livraisons";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(772, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Categories";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(515, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Fournisseurs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(329, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Articles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 994);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 45);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(462, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion de stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 75);
            this.panel1.TabIndex = 32;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(22, 797);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(245, 35);
            this.telephone.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 754);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 29);
            this.label11.TabIndex = 62;
            this.label11.Text = "Telephone:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(22, 697);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(238, 35);
            this.email.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 655);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 29);
            this.label12.TabIndex = 60;
            this.label12.Text = "Email:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 663);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(143, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 29);
            this.label13.TabIndex = 66;
            this.label13.Text = "Clients";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::gestion_de_stock.Properties.Resources.customer_service;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Location = new System.Drawing.Point(58, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(79, 70);
            this.panel8.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_de_stock.Properties.Resources.fournisseur;
            this.pictureBox1.Location = new System.Drawing.Point(101, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 73);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::gestion_de_stock.Properties.Resources.se_deconnecter;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Location = new System.Drawing.Point(1137, 92);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(70, 70);
            this.panel7.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::gestion_de_stock.Properties.Resources.expedie;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(922, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 70);
            this.panel5.TabIndex = 39;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::gestion_de_stock.Properties.Resources.ajouter_une_application;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(684, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 70);
            this.panel6.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::gestion_de_stock.Properties.Resources.fournisseur;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(439, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 70);
            this.panel4.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::gestion_de_stock.Properties.Resources.achats_et_commerce;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(248, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 70);
            this.panel3.TabIndex = 34;
            // 
            // fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 1039);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppliers";
            this.Load += new System.EventHandler(this.fournisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
    }
}