
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
            this.bateauAffichage = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bateauAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "E ce que git marche";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bateauAffichage
            // 
            this.bateauAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bateauAffichage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Longueur,
            this.Largeur,
            this.vitesse,
            this.Personnes,
            this.vehicule});
            this.bateauAffichage.Location = new System.Drawing.Point(60, 208);
            this.bateauAffichage.Name = "bateauAffichage";
            this.bateauAffichage.RowTemplate.Height = 25;
            this.bateauAffichage.Size = new System.Drawing.Size(642, 176);
            this.bateauAffichage.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // Longueur
            // 
            this.Longueur.HeaderText = "Longueur";
            this.Longueur.Name = "Longueur";
            // 
            // Largeur
            // 
            this.Largeur.HeaderText = "Largeur";
            this.Largeur.Name = "Largeur";
            // 
            // vitesse
            // 
            this.vitesse.HeaderText = "Vitesse";
            this.vitesse.Name = "vitesse";
            // 
            // Personnes
            // 
            this.Personnes.HeaderText = "personnes";
            this.Personnes.Name = "Personnes";
            // 
            // vehicule
            // 
            this.vehicule.HeaderText = "vehicule";
            this.vehicule.Name = "vehicule";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(500, 105);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.bateauAffichage);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bateauAffichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
       
        
      
        private System.Windows.Forms.DataGridView bateauAffichage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicule;
        private System.Windows.Forms.Button btn1;
    }
}

