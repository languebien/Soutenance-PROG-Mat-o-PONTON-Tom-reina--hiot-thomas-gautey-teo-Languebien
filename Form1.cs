using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appli_groupe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bateau b1 = new Bateau("tt", 9.5, 9.5, 90, 50, 6);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
            
      

        private void button1_Click_1(object sender, EventArgs e)

        {


            for (int i = 0; i < 5; i++)
            {

                tableauBateau.Rows.Add(b1.getNom(), b1.getLongueur(), b1.getLargeur(), b1.getVitesse(), b1.getNbPassagers(), b1.getNbVoitures());
            }

        }
    }
}
