
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
            this.modifierDateTraverseeBateau = new System.Windows.Forms.Button();
            this.dateTraverseeBateau = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.TabControl();
            this.billetterie = new System.Windows.Forms.TabPage();
            this.traversees = new System.Windows.Forms.TabPage();
            this.bateaux = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.bateaux.SuspendLayout();
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
            this.dgvB.Location = new System.Drawing.Point(6, 27);
            this.dgvB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowHeadersWidth = 51;
            this.dgvB.RowTemplate.Height = 25;
            this.dgvB.Size = new System.Drawing.Size(639, 72);
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
            this.comboBox1.Location = new System.Drawing.Point(173, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(53, 55);
            this.txNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(317, 27);
            this.txNom.TabIndex = 5;
            // 
            // txLongeur
            // 
            this.txLongeur.Location = new System.Drawing.Point(83, 85);
            this.txLongeur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txLongeur.Name = "txLongeur";
            this.txLongeur.Size = new System.Drawing.Size(287, 27);
            this.txLongeur.TabIndex = 6;
            // 
            // txVoiture
            // 
            this.txVoiture.Location = new System.Drawing.Point(74, 210);
            this.txVoiture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txVoiture.Name = "txVoiture";
            this.txVoiture.Size = new System.Drawing.Size(296, 27);
            this.txVoiture.TabIndex = 7;
            // 
            // txPassager
            // 
            this.txPassager.Location = new System.Drawing.Point(79, 180);
            this.txPassager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPassager.Name = "txPassager";
            this.txPassager.Size = new System.Drawing.Size(291, 27);
            this.txPassager.TabIndex = 8;
            // 
            // txVitesse
            // 
            this.txVitesse.Location = new System.Drawing.Point(67, 149);
            this.txVitesse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txVitesse.Name = "txVitesse";
            this.txVitesse.Size = new System.Drawing.Size(303, 27);
            this.txVitesse.TabIndex = 9;
            // 
            // txLargeur
            // 
            this.txLargeur.Location = new System.Drawing.Point(79, 117);
            this.txLargeur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txLargeur.Name = "txLargeur";
            this.txLargeur.Size = new System.Drawing.Size(291, 27);
            this.txLargeur.TabIndex = 10;
            // 
            // info
            // 
            this.info.Controls.Add(this.modifierDateTraverseeBateau);
            this.info.Controls.Add(this.dateTraverseeBateau);
            this.info.Controls.Add(this.label9);
            this.info.Controls.Add(this.label8);
            this.info.Controls.Add(this.label7);
            this.info.Controls.Add(this.label6);
            this.info.Controls.Add(this.label5);
            this.info.Controls.Add(this.label4);
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.comboBox1);
            this.info.Controls.Add(this.txNom);
            this.info.Controls.Add(this.txVoiture);
            this.info.Controls.Add(this.txPassager);
            this.info.Controls.Add(this.txVitesse);
            this.info.Controls.Add(this.txLargeur);
            this.info.Controls.Add(this.txLongeur);
            this.info.Location = new System.Drawing.Point(6, 107);
            this.info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.info.Size = new System.Drawing.Size(650, 253);
            this.info.TabIndex = 11;
            this.info.TabStop = false;
            this.info.Text = "Modifier les Bateaux";
            // 
            // modifierDateTraverseeBateau
            // 
            this.modifierDateTraverseeBateau.Location = new System.Drawing.Point(446, 79);
            this.modifierDateTraverseeBateau.Name = "modifierDateTraverseeBateau";
            this.modifierDateTraverseeBateau.Size = new System.Drawing.Size(134, 29);
            this.modifierDateTraverseeBateau.TabIndex = 22;
            this.modifierDateTraverseeBateau.Text = "Modifier la date";
            this.modifierDateTraverseeBateau.UseVisualStyleBackColor = true;
            this.modifierDateTraverseeBateau.Click += new System.EventHandler(this.modifierDateTraverseeBateau_Click);
            // 
            // dateTraverseeBateau
            // 
            this.dateTraverseeBateau.Location = new System.Drawing.Point(394, 47);
            this.dateTraverseeBateau.Name = "dateTraverseeBateau";
            this.dateTraverseeBateau.Size = new System.Drawing.Size(245, 27);
            this.dateTraverseeBateau.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Date de prochaine visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Voitures";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Passagers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vitesse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Largueur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Longueur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Séléctionner un Bateau";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvB);
            this.groupBox1.Controls.Add(this.info);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 370);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Bateaux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Compagnie Océane";
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.billetterie);
            this.Wrapper.Controls.Add(this.traversees);
            this.Wrapper.Controls.Add(this.bateaux);
            this.Wrapper.Location = new System.Drawing.Point(12, 40);
            this.Wrapper.Multiline = true;
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.SelectedIndex = 0;
            this.Wrapper.Size = new System.Drawing.Size(1346, 586);
            this.Wrapper.TabIndex = 14;
            // 
            // billetterie
            // 
            this.billetterie.Location = new System.Drawing.Point(4, 29);
            this.billetterie.Name = "billetterie";
            this.billetterie.Padding = new System.Windows.Forms.Padding(3);
            this.billetterie.Size = new System.Drawing.Size(629, 190);
            this.billetterie.TabIndex = 1;
            this.billetterie.Text = "Billeterie";
            this.billetterie.UseVisualStyleBackColor = true;
            // 
            // traversees
            // 
            this.traversees.Location = new System.Drawing.Point(4, 29);
            this.traversees.Name = "traversees";
            this.traversees.Padding = new System.Windows.Forms.Padding(3);
            this.traversees.Size = new System.Drawing.Size(629, 190);
            this.traversees.TabIndex = 2;
            this.traversees.Text = "Traversées";
            this.traversees.UseVisualStyleBackColor = true;
            // 
            // bateaux
            // 
            this.bateaux.Controls.Add(this.groupBox1);
            this.bateaux.Location = new System.Drawing.Point(4, 29);
            this.bateaux.Name = "bateaux";
            this.bateaux.Padding = new System.Windows.Forms.Padding(3);
            this.bateaux.Size = new System.Drawing.Size(1338, 553);
            this.bateaux.TabIndex = 3;
            this.bateaux.Text = "Bateaux";
            this.bateaux.UseVisualStyleBackColor = true;
            // 
            // cbbateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 883);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.label1);
            this.Name = "cbbateau";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.bateaux.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifierDateTraverseeBateau;
        private System.Windows.Forms.DateTimePicker dateTraverseeBateau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl Wrapper;
        private System.Windows.Forms.TabPage billetterie;
        private System.Windows.Forms.TabPage traversees;
        private System.Windows.Forms.TabPage bateaux;
    }
}

