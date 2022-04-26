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
        List <Bateau> ListeBateau;
        List <Traversee> ListeTraversees;
        List <Port> ListePort;
        public cbbateau()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // B A T E A U X //
            bateau1 = new Bateau("Ultra Fat Raccoon", 9.5, 9.5, 90, 50, 6);
            bateau2 = new Bateau("Mega Moose", 9.5, 9.5, 90, 50, 6);
            bateau3 = new Bateau("Cosmic Taco Whale", 9.5, 9.5, 90, 50, 6);
            bateau4 = new Bateau("Baleine Géante", 9.5, 9.5, 90, 50, 6);
            bateau5 = new Bateau("Sea Master", 9.5, 9.5, 90, 50, 6);
            bateau6 = new Bateau("Enormous Megaloodoon with Pizza", 9.5, 9.5, 90, 50, 6);
            ListeBateau = new List<Bateau>();
            ListeBateau.Add(bateau1);
            ListeBateau.Add(bateau1);
            ListeBateau.Add(bateau2);
            ListeBateau.Add(bateau3);
            ListeBateau.Add(bateau4);
            ListeBateau.Add(bateau5);
            ListeBateau.Add(bateau6);
            DateTime datebateau = new DateTime(2020, 06, 06);
            bateau1.setDateVisite(datebateau);
            bateau2.setDateVisite(datebateau);
            bateau3.setDateVisite(datebateau);
            bateau4.setDateVisite(datebateau);
            bateau5.setDateVisite(datebateau);
            bateau6.setDateVisite(datebateau);

            // P O R T S //
            port1 = new Port("Fat Raccoon City");
            port2 = new Port("Mango Loco Plaja");
            port3 = new Port("Ultra Cheese Megaloodoon");
            port4 = new Port("Lyonzon");
            ListePort = new List<Port>();
            ListePort.Add(port1);
            ListePort.Add(port2);
            ListePort.Add(port3);
            ListePort.Add(port4);

            // T R A V E R S E E S //
            DateTime datetraverser1 = new DateTime(2025, 12, 25);
            DateTime datetraverser2 = new DateTime(2022, 12, 25);
            Traversee Traversee1 = new Traversee(69, datetraverser1, 2, 100, 20, bateau4, port4, port1);
            Traversee Traversee2 = new Traversee(11, datetraverser1, 2, 150, 35, bateau6, port3, port2);
            ListeTraversees = new List<Traversee>();
            ListeTraversees.Add(Traversee1);
            ListeTraversees.Add(Traversee2);

            // A J O U T E   B A T E A U X   P A G E   B A T E A U X //
            for (int i = 0; i < ListeBateau.Count; i++)
            {
                dgvB.Rows.Add(ListeBateau.ElementAt(i).getNomBateau(), ListeBateau.ElementAt(i).getLongueur(), ListeBateau.ElementAt(i).getLargeur(), ListeBateau.ElementAt(i).getVitesse(), ListeBateau.ElementAt(i).getNbPassagers(), ListeBateau.ElementAt(i).getNbVoitures());
            }

            // A J O U T E   T R A V E R S E E S   P A G E   T R A V E R S E E S //
            for (int i = 0; i < ListeTraversees.Count; i++)
            {
                affichageTraversees.Rows.Add(ListeTraversees.ElementAt(i).getNumerp(), ListeTraversees.ElementAt(i).getDateDepart(), ListeTraversees.ElementAt(i).getDuree(), ListeTraversees.ElementAt(i).getPortPassagers(), ListeTraversees.ElementAt(i).getPortVehicules(), ListeTraversees.ElementAt(i).getBateau().getNomBateau(), ListeTraversees.ElementAt(i).getPortDepart().getNomPort(), ListeTraversees.ElementAt(i).getPortArrivee().getNomPort());
            }

            // A J O U T E   T R A V E R S E E S   P A G E   B I L E E T S //
            for (int i = 0; i < ListeTraversees.Count; i++)
            {
                selectionReservationTraversee.Rows.Add(ListeTraversees.ElementAt(i).getNumerp(), ListeTraversees.ElementAt(i).getDateDepart(), ListeTraversees.ElementAt(i).getDuree(), ListeTraversees.ElementAt(i).getPortPassagers(), ListeTraversees.ElementAt(i).getPortVehicules(), ListeTraversees.ElementAt(i).getBateau().getNomBateau(), ListeTraversees.ElementAt(i).getPortDepart().getNomPort(), ListeTraversees.ElementAt(i).getPortArrivee().getNomPort());
            }

            // B A T E A U X   -   Remplissage automatique des comboboxes bateaux //
            // Bateaux // 
            for (int i = 1; i < ListeBateau.Count; i++)
            {
                selectionModifierBateau.Items.Add(ListeBateau[i].getNomBateau().ToString());
            }

            // T R A V E R S E E S   -   Remplissage automatique des comboboxes Traversées //
            // Bateaux // 
            for (int i = 1; i < ListeBateau.Count; i++)
            {
                selectionBateauxCreation.Items.Add(ListeBateau[i].getNomBateau().ToString());
            }
            // Ports // 
            for (int i = 0; i < ListePort.Count; i++)
            {
                selectionPortsDepartRecherche.Items.Add(ListePort[i].getNomPort().ToString());
                selectionPortsArriveeRecherche.Items.Add(ListePort[i].getNomPort().ToString());
                selectionPortsDepartCreation.Items.Add(ListePort[i].getNomPort().ToString());
                selectionPortsArriveeCreation.Items.Add(ListePort[i].getNomPort().ToString());

                reservationTraverseePortDepart.Items.Add(ListePort[i].getNomPort().ToString());
                reservationTraverseePortArrivee.Items.Add(ListePort[i].getNomPort().ToString());
            }
        }

        // Affiche les informations dans les zones de texte quand un bateau est séléctionné //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bateauchoix = selectionModifierBateau.SelectedIndex;
            bateauchoix = bateauchoix + 1;
            txNom.Text = ListeBateau.ElementAt(bateauchoix).getNomBateau();
            txNom.Enabled = false;
            txLargeur.Text = ListeBateau.ElementAt(bateauchoix).getLargeur().ToString();
            txLargeur.Enabled = false;
            txLongeur.Text = ListeBateau.ElementAt(bateauchoix).getLongueur().ToString();
            txLongeur.Enabled = false;
            txPassager.Text = ListeBateau.ElementAt(bateauchoix).getNbPassagers().ToString();
            txPassager.Enabled = false;
            txVitesse.Text = ListeBateau.ElementAt(bateauchoix).getVitesse().ToString();
            txVitesse.Enabled=false;
            txVoiture.Text = ListeBateau.ElementAt(bateauchoix).getNbVoitures().ToString();
            txVoiture.Enabled = false;
            dateTraverseeBateau.Text = ListeBateau.ElementAt(bateauchoix).getDateVisite().ToString();
        }

        // Change la date de traversée du bateau //
        private void modifierDateTraverseeBateau_Click(object sender, EventArgs e)
        {
            int bateauchoix = selectionModifierBateau.SelectedIndex;
            bateauchoix = bateauchoix + 1;
            string theDate = dateTraverseeBateau.Value.ToShortDateString();
            ListeBateau.ElementAt(bateauchoix).setDateVisite(DateTime.Parse(dateTraverseeBateau.Text));

        }

        // Page Traversée, recherche une traversée //
        private void recherche_Click(object sender, EventArgs e)
        {
            String depart = selectionPortsDepartRecherche.Text;
            String arrivee = selectionPortsArriveeRecherche.Text;
            String date = dtpTraversée.Value.ToShortDateString();

            for (int i = 0; i < ListeTraversees.Count; i++)
            {
                String portD = (string)affichageTraversees[6, i].Value;
                String portA = (string)affichageTraversees[7, i].Value;
                DateTime portDate =(DateTime) affichageTraversees[1, i].Value;
                
                if (portD == depart & portA == arrivee & portDate.ToShortDateString() == date)
                {
                    affichageRechercheTraversee.Rows.Add(ListeTraversees.ElementAt(i).getNumerp(), ListeTraversees.ElementAt(i).getDateDepart(), ListeTraversees.ElementAt(i).getDuree(), ListeTraversees.ElementAt(i).getPortPassagers(), ListeTraversees.ElementAt(i).getPortVehicules(), ListeTraversees.ElementAt(i).getBateau().getNomBateau(), ListeTraversees.ElementAt(i).getPortDepart().getNomPort(), ListeTraversees.ElementAt(i).getPortArrivee().getNomPort());

                }
            }
        }

        // R E S E R V A T I O N - Quand on clique sur le bouton réservation //
        private void button1_Click_1(object sender, EventArgs e)
        {
            String depart = reservationTraverseePortDepart.Text;
            String arrivee = reservationTraverseePortArrivee.Text;
            String date = dtpBillet.Value.ToShortDateString();
            string bateau="";
            string num ="";
            int dureeTrajet= 0;


            for (int i = 0; i < ListeTraversees.Count; i++)
            {
                String portD = (string)selectionReservationTraversee[6, i].Value;
                String portA = (string)selectionReservationTraversee[7, i].Value;
                DateTime portDate = (DateTime)selectionReservationTraversee[1, i].Value;

                if (portD == depart & portA == arrivee & portDate.ToShortDateString() == date)
                {
                        num = ListeTraversees.ElementAt(i).getNumerp().ToString();
                        
                      dureeTrajet=  ListeTraversees.ElementAt(i).getDuree();
                    bateau = ListeTraversees.ElementAt(i).getBateau().getNomBateau();
                }
            }
            lClient.Text = reservationPrenom.Text + " " + reservationNom.Text;
            dateDB.Text = date;
            bateauBillet.Text = bateau;
            portDepartBillet.Text = depart;
            dureeTrajetBillet.Text = dureeTrajet.ToString() + " Heure(s)";
            lPortArriveeBillet.Text = arrivee;
            nbVBillet.Text = reservationNbVehicules.Text;
            nbPBillet.Text = reservationNbPassagers.Text;

            // Calcul Prix //
            int NombresPersonnes = Int32.Parse(reservationNbPassagers.Text);
            int NombreVehicules = Int32.Parse(reservationNbVehicules.Text);

            int PrixTotalPresonnes = NombresPersonnes * 5;
            int PrixTotalVehicules = NombreVehicules * 30;

            int PrixTotal = PrixTotalVehicules + PrixTotalPresonnes;
            String PrixTotalText = PrixTotal.ToString();

            texteReservationPrix.Text = PrixTotalText;

            // Envoi des Statistiques des personnes et vehicules //
            int StatPersonnes = Int32.Parse(reservationNbPassagers.Text);
            int StatPersonnesPrecedente = Int32.Parse(statPersonnes.Text);
            int StatTotalPersonnes = StatPersonnesPrecedente + StatPersonnes;
            statPersonnes.Text = StatTotalPersonnes.ToString();

            int StatVehicules = Int32.Parse(reservationNbVehicules.Text);
            int StatVehiculesPrecedente = Int32.Parse(statVehicules.Text);
            int StatTotalVehicules = StatVehiculesPrecedente + StatVehicules;
            statVehicules.Text = StatTotalVehicules.ToString();

            // chiffre d'affaires //
            int StatChiffreAffairePrecedent = Int32.Parse(statChiffreAffaire.Text);
            int StatTChiffreAffaire = StatChiffreAffairePrecedent + PrixTotal;
            statChiffreAffaire.Text = StatTChiffreAffaire.ToString();

            // Commande Enregistrée //
            commandeEnregistree.Text = "Commande Enregistrée";
        }

        //  Réservation d'une autre commande //
        private void button2_Click(object sender, EventArgs e)
        {
            lClient.Text = "";
            dateDB.Text = "";
            bateauBillet.Text = "";
            nbPBillet.Text = "";
            portDepartBillet.Text = "";
            dureeTrajetBillet.Text = "";
            nbVBillet.Text = "";
            lPortArriveeBillet.Text = "";
            reservationNbPassagers.Text = "";
            reservationNbVehicules.Text = "";
            reservationPrenom.Text = "";
            reservationNom.Text = "";

            commandeEnregistree.Text = "";
        }



        // P O U B E L L E //
        private void txvisite_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void selectionPortsDepartRecherche_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            for (int i = 0; i < ListeTraversees.Count; i++)
            {
                if (selectionPortsDepartRecherche.SelectedIndex.ToString() == ListeTraversees.ElementAt(i).getPortDepart().getNomPort())
                {
                    affichageRechercheTraversee.Rows.Add(ListeTraversees.ElementAt(i).getNumerp(), ListeTraversees.ElementAt(i).getDateDepart(), ListeTraversees.ElementAt(i).getDuree(), ListeTraversees.ElementAt(i).getPortPassagers(), ListeTraversees.ElementAt(i).getPortVehicules(), ListeTraversees.ElementAt(i).getBateau().getNomBateau(), selectionPortsDepartRecherche.SelectedIndex.ToString(), ListeTraversees.ElementAt(i).getPortArrivee().getNomPort());
                    break;
                }
            }
        }
        private void selectionPortsArriveeRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void selectionPortsDepartCreation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void selectionPortsArriveeCreation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boutonCreationTraversee_Click(object sender, EventArgs e)
        {
            String BateauSelectionne = selectionBateauxCreation.Text;
            String PortDepart = selectionPortsDepartCreation.Text;
            String PortArrivee = selectionPortsArriveeCreation.Text;

            visuTraverseeCree.Rows.Add(BateauSelectionne, PortDepart, PortArrivee);
            
           
        }

        private void dtpTraversée_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rechercheTraversee_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
