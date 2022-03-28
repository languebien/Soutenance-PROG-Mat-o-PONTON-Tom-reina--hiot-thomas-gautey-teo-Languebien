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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bateau1 = new Bateau("BigBoobs", 9.5, 9.5, 90, 50, 6);
            bateau2 = new Bateau("FatFlyingRacoon", 9.5, 9.5, 90, 50, 6);
            bateau3 = new Bateau("FatDrumandBassRacoon", 9.5, 9.5, 90, 50, 6);
            bateau4 = new Bateau("MOUSE", 9.5, 9.5, 90, 50, 6);
            bateau5 = new Bateau("Chocolatine", 9.5, 9.5, 90, 50, 6);
            bateau6 = new Bateau("CasaNobile", 9.5, 9.5, 90, 50, 6);
            port1 = new Port("CreamyPort");
            port2 = new Port("RacoonPort");
            port3 = new Port("CreaspyBaconPort");
            port4 = new Port("CheesyCheedarPort");
            port5 = new Port("SoiréeMariePort");
            port6 = new Port("FatRacoonCity");
            bateau = new List<Bateau>();
            bateau.Add(bateau1);
            bateau.Add(bateau1);
            bateau.Add(bateau2);
            bateau.Add(bateau3);
            bateau.Add(bateau4);
            bateau.Add(bateau5);
            bateau.Add(bateau6);
            DateTime datetraverser1 = new DateTime(2025, 12, 25);
            DateTime datetraverser2 = new DateTime(2022, 12, 25);
            Traversee RacoonVoyage = new Traversee(69, datetraverser1, 2, port6, port4);
            Traversee TripleCheesePlusCheedar = new Traversee(11, datetraverser1, 2, port2, port5);
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bateau.Count; i++)
            {
                dgvB.Rows.Add(bateau.ElementAt(i).getNom(),bateau.ElementAt(i).getLongueur(), bateau.ElementAt(i).getLargeur(), bateau.ElementAt(i).getVitesse(), bateau.ElementAt(i).getNbPassagers(), bateau.ElementAt(i).getNbVoitures()) ;

            }

        }
    }
}
