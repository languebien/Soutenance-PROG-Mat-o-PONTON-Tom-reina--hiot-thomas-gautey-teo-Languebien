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
            Bateau bateau1 = new Bateau("BigBoobs", 9.5, 9.5, 90, 50, 6);
            Bateau bateau2 = new Bateau("FatFlyingRacoon", 9.5, 9.5, 90, 50, 6);
            Bateau bateau3 = new Bateau("FatDrumandBassRacoon", 9.5, 9.5, 90, 50, 6);
            Bateau bateau4 = new Bateau("MOUSE", 9.5, 9.5, 90, 50, 6);
            Bateau bateau5 = new Bateau("Chocolatine", 9.5, 9.5, 90, 50, 6);
            Bateau bateau6 = new Bateau("CasaNobile", 9.5, 9.5, 90, 50, 6);
            Port port1 = new Port("CreamyPort");
            Port port2 = new Port("RacoonPort");
            Port port3 = new Port("CreaspyBaconPort");
            Port port4 = new Port("CheesyCheedarPort");
            Port port5 = new Port("SoiréeMariePort");
            Port port6 = new Port("FatRacoonCity");
        }
        
        
    }
}
