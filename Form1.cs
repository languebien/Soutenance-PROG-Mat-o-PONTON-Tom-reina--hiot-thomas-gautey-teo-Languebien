using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace appli_groupe
{
    public partial class cbbateau : Form
    {
       

        Bateau bateau1;
        Bateau bateau2;
        Bateau bateau3;
        Bateau bateau4;
        Bateau bateau5;
        Bateau bateau6;
        Port port1;
        Port port2;
        Port port3;
        Port port4;
        Port port5;
        Port port6;
        List <Bateau> bateau ;
        public cbbateau()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bateau1 = new Bateau("Ultra Fat Raccoon", 9.5, 9.5, 90, 50, 6);
            bateau2 = new Bateau("Fat Flying Racoon", 9.5, 9.5, 90, 50, 6);
            bateau3 = new Bateau("Fat Drum & Bass Raccoon", 9.5, 9.5, 90, 50, 6);
            bateau4 = new Bateau("MOUSE", 9.5, 9.5, 90, 50, 6);
            bateau5 = new Bateau("Chocolatine", 9.5, 9.5, 90, 50, 6);
            bateau6 = new Bateau("CasaNobile", 9.5, 9.5, 90, 50, 6);
            port1 = new Port("Creamy Port");
            port2 = new Port("Racoon Port");
            port3 = new Port("Creaspy Bacon Port");
            port4 = new Port("Cheesy Cheedar Port");
            port5 = new Port("Soirée Marie Port");
            port6 = new Port("Fat Racoon City");
            bateau = new List<Bateau>();
            bateau.Add(bateau1);
            bateau.Add(bateau1);
            bateau.Add(bateau2);
            bateau.Add(bateau3);
            bateau.Add(bateau4);
            bateau.Add(bateau5);
            bateau.Add(bateau6);
            DateTime datebateau = new DateTime(2020, 06, 06);
            bateau1.setDateVisite(datebateau);
            bateau2.setDateVisite(datebateau);
            bateau3.setDateVisite(datebateau);
            bateau4.setDateVisite(datebateau);
            bateau5.setDateVisite(datebateau);
            bateau6.setDateVisite(datebateau);
            DateTime datetraverser1 = new DateTime(2025, 12, 25);
            DateTime datetraverser2 = new DateTime(2022, 12, 25);
            Traversee RacoonVoyage = new Traversee(69, datetraverser1, 2, port6, port4);
            Traversee TripleCheesePlusCheedar = new Traversee(11, datetraverser1, 2, port2, port5);

            // Boucle qui ajoute les bateaux
            for (int i = 0; i < bateau.Count; i++)
            {
                dgvB.Rows.Add(bateau.ElementAt(i).getNom(), bateau.ElementAt(i).getLongueur(), bateau.ElementAt(i).getLargeur(), bateau.ElementAt(i).getVitesse(), bateau.ElementAt(i).getNbPassagers(), bateau.ElementAt(i).getNbVoitures());

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bateauchoix = comboBox1.SelectedIndex;
            bateauchoix = bateauchoix + 1;
            txNom.Text = bateau.ElementAt(bateauchoix).getNom();
            txNom.Enabled = false;
            txLargeur.Text = bateau.ElementAt(bateauchoix).getLargeur().ToString();
            txLargeur.Enabled = false;
            txLongeur.Text = bateau.ElementAt(bateauchoix).getLongueur().ToString();
            txLongeur.Enabled = false;
            txPassager.Text = bateau.ElementAt(bateauchoix).getNbPassagers().ToString();
            txPassager.Enabled = false;
            txVitesse.Text = bateau.ElementAt(bateauchoix).getVitesse().ToString();
            txVitesse.Enabled=false;
            txVoiture.Text = bateau.ElementAt(bateauchoix).getNbVoitures().ToString();
            txVoiture.Enabled = false;
            dateTraverseeBateau.Text = bateau.ElementAt(bateauchoix).getDateVisite().ToString();
        }
        private void modifierDateTraverseeBateau_Click(object sender, EventArgs e)
        {
            int bateauchoix = comboBox1.SelectedIndex;
            bateauchoix = bateauchoix + 1;
            string theDate = dateTraverseeBateau.Value.ToShortDateString();
            bateau.ElementAt(bateauchoix).setDateVisite(DateTime.Parse(dateTraverseeBateau.Text));
        }



        // P O U B E L L E
        private void txvisite_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
