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
        ArrayList bateau;
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
            bateau.Add(bateau1);
            bateau.Add(bateau2);
            bateau.Add(bateau3);
            bateau.Add(bateau4);
            bateau.Add(bateau5);
            bateau.Add(bateau6);

        }
        
        private void button1_Click_1(object sender,EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            for (int i =0; i < bateau.Count ; i++)
            {
                
                bateauAffichage.Rows.Add(bateau.Get(i).getNom);
            }
        }
    }
}
