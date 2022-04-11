
namespace appli_groupe
{
    partial class cbbateau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; /// <summary>
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
        #region Windows Form Designer generated code /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passagers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voitures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txLongeur = new System.Windows.Forms.TextBox();
            this.txVoiture = new System.Windows.Forms.TextBox();
            this.txPassager = new System.Windows.Forms.TextBox();
            this.txVitesse = new System.Windows.Forms.TextBox();
            this.txLargeur = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.GroupBox();
            this.txvisite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Longueur,
            this.largueur,
            this.vitesse,
            this.passagers,
            this.voitures});
            this.dgvB.Location = new System.Drawing.Point(5, 20);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowHeadersWidth = 51;
            this.dgvB.RowTemplate.Height = 25;
            this.dgvB.Size = new System.Drawing.Size(822, 174);
            this.dgvB.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // Longueur
            // 
            this.Longueur.HeaderText = "longueur";
            this.Longueur.MinimumWidth = 6;
            this.Longueur.Name = "Longueur";
            this.Longueur.Width = 125;
            // 
            // largueur
            // 
            this.largueur.HeaderText = "largueur";
            this.largueur.MinimumWidth = 6;
            this.largueur.Name = "largueur";
            this.largueur.Width = 125;
            // 
            // vitesse
            // 
            this.vitesse.HeaderText = "vitesse";
            this.vitesse.MinimumWidth = 6;
            this.vitesse.Name = "vitesse";
            this.vitesse.Width = 125;
            // 
            // passagers
            // 
            this.passagers.HeaderText = "passagers";
            this.passagers.MinimumWidth = 6;
            this.passagers.Name = "passagers";
            this.passagers.Width = 125;
            // 
            // voitures
            // 
            this.voitures.HeaderText = "voiture";
            this.voitures.MinimumWidth = 6;
            this.voitures.Name = "voitures";
            this.voitures.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BigBoobs",
            "FatFlyingRacoon",
            "FatDrumandBassRacoon",
            "mouse",
            "Chocolatine",
            "casaNobile"});
            this.comboBox1.Location = new System.Drawing.Point(13, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(0, 22);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(100, 23);
            this.txNom.TabIndex = 5;
            // 
            // txLongeur
            // 
            this.txLongeur.Location = new System.Drawing.Point(0, 51);
            this.txLongeur.Name = "txLongeur";
            this.txLongeur.Size = new System.Drawing.Size(100, 23);
            this.txLongeur.TabIndex = 6;
            // 
            // txVoiture
            // 
            this.txVoiture.Location = new System.Drawing.Point(0, 167);
            this.txVoiture.Name = "txVoiture";
            this.txVoiture.Size = new System.Drawing.Size(100, 23);
            this.txVoiture.TabIndex = 7;
            // 
            // txPassager
            // 
            this.txPassager.Location = new System.Drawing.Point(0, 138);
            this.txPassager.Name = "txPassager";
            this.txPassager.Size = new System.Drawing.Size(100, 23);
            this.txPassager.TabIndex = 8;
            // 
            // txVitesse
            // 
            this.txVitesse.Location = new System.Drawing.Point(0, 109);
            this.txVitesse.Name = "txVitesse";
            this.txVitesse.Size = new System.Drawing.Size(100, 23);
            this.txVitesse.TabIndex = 9;
            // 
            // txLargeur
            // 
            this.txLargeur.Location = new System.Drawing.Point(0, 80);
            this.txLargeur.Name = "txLargeur";
            this.txLargeur.Size = new System.Drawing.Size(100, 23);
            this.txLargeur.TabIndex = 10;
            // 
            // info
            // 
            this.info.Controls.Add(this.txvisite);
            this.info.Controls.Add(this.txNom);
            this.info.Controls.Add(this.txVoiture);
            this.info.Controls.Add(this.txPassager);
            this.info.Controls.Add(this.txVitesse);
            this.info.Controls.Add(this.txLargeur);
            this.info.Controls.Add(this.txLongeur);
            this.info.Location = new System.Drawing.Point(15, 230);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(119, 225);
            this.info.TabIndex = 11;
            this.info.TabStop = false;
            this.info.Text = "info bateau";
            // 
            // txvisite
            // 
            this.txvisite.Location = new System.Drawing.Point(0, 196);
            this.txvisite.Name = "txvisite";
            this.txvisite.Size = new System.Drawing.Size(100, 23);
            this.txvisite.TabIndex = 12;
            this.txvisite.TextChanged += new System.EventHandler(this.txvisite_TextChanged);
            // 
            // cbbateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 662);
            this.Controls.Add(this.info);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cbbateau";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn largueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn passagers;
        private System.Windows.Forms.DataGridViewTextBoxColumn voitures;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txLongeur;
        private System.Windows.Forms.TextBox txVoiture;
        private System.Windows.Forms.TextBox txPassager;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txLargeur;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.TextBox txVitesse;
        private System.Windows.Forms.TextBox txvisite;
    }
}

