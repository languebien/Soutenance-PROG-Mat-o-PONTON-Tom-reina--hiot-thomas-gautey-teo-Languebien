
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
            this.tableauBateau = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauBateau)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 13);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "E ce que git marche";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableauBateau
            // 
            this.tableauBateau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauBateau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.longueur,
            this.largeur,
            this.vitesse,
            this.personne,
            this.vehicule});
            this.tableauBateau.Location = new System.Drawing.Point(56, 277);
            this.tableauBateau.Name = "tableauBateau";
            this.tableauBateau.RowHeadersWidth = 51;
            this.tableauBateau.RowTemplate.Height = 25;
            this.tableauBateau.Size = new System.Drawing.Size(642, 161);
            this.tableauBateau.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // longueur
            // 
            this.longueur.HeaderText = "longueur";
            this.longueur.MinimumWidth = 6;
            this.longueur.Name = "longueur";
            this.longueur.Width = 125;
            // 
            // largeur
            // 
            this.largeur.HeaderText = "largeur";
            this.largeur.MinimumWidth = 6;
            this.largeur.Name = "largeur";
            this.largeur.Width = 125;
            // 
            // vitesse
            // 
            this.vitesse.HeaderText = "vitesse";
            this.vitesse.MinimumWidth = 6;
            this.vitesse.Name = "vitesse";
            this.vitesse.Width = 125;
            // 
            // personne
            // 
            this.personne.HeaderText = "personne";
            this.personne.MinimumWidth = 6;
            this.personne.Name = "personne";
            this.personne.Width = 125;
            // 
            // vehicule
            // 
            this.vehicule.HeaderText = "vehicule";
            this.vehicule.MinimumWidth = 6;
            this.vehicule.Name = "vehicule";
            this.vehicule.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauBateau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView tableauBateau;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn largeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn personne;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicule;
        private System.Windows.Forms.Button button1;
    }
}

