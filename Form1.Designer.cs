
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
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passagers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voitures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifierBateaux = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgvB.Size = new System.Drawing.Size(805, 94);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Compagnie Océane";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvB);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 350);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bateaux";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // modifierBateaux
            // 
            this.modifierBateaux.FormattingEnabled = true;
            this.modifierBateaux.Location = new System.Drawing.Point(6, 26);
            this.modifierBateaux.Name = "modifierBateaux";
            this.modifierBateaux.Size = new System.Drawing.Size(297, 28);
            this.modifierBateaux.TabIndex = 4;
            // 
            // groupBox2
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
    }
}

