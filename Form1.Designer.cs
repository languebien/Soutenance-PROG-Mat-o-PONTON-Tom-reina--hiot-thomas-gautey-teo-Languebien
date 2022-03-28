
namespace appli_groupe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passagers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voitures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBateau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 8);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "E ce que git marche";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgvB.Location = new System.Drawing.Point(9, 148);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowTemplate.Height = 25;
            this.dgvB.Size = new System.Drawing.Size(642, 135);
            this.dgvB.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // Longueur
            // 
            this.Longueur.HeaderText = "longueur";
            this.Longueur.Name = "Longueur";
            // 
            // largueur
            // 
            this.largueur.HeaderText = "largueur";
            this.largueur.Name = "largueur";
            // 
            // vitesse
            // 
            this.vitesse.HeaderText = "vitesse";
            this.vitesse.Name = "vitesse";
            // 
            // passagers
            // 
            this.passagers.HeaderText = "passagers";
            this.passagers.Name = "passagers";
            // 
            // voitures
            // 
            this.voitures.HeaderText = "voiture";
            this.voitures.Name = "voitures";
            // 
            // cbBateau
            // 
            this.cbBateau.FormattingEnabled = true;
            this.cbBateau.Items.AddRange(new object[] {
            "BigBoobs",
            "FatFlyingRacoon",
            "DatDrumandBassRacoon",
            "mouse",
            "chocolatine",
            "casanobile"});
            this.cbBateau.Location = new System.Drawing.Point(31, 318);
            this.cbBateau.Name = "cbBateau";
            this.cbBateau.Size = new System.Drawing.Size(177, 23);
            this.cbBateau.TabIndex = 4;
            this.cbBateau.Text = "choisir un bateau a modifier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 677);
            this.Controls.Add(this.cbBateau);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn largueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn passagers;
        private System.Windows.Forms.DataGridViewTextBoxColumn voitures;
        private System.Windows.Forms.ComboBox cbBateau;
    }
}

