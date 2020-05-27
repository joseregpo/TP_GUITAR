using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Guitar_Client
{
    public partial class Commander_Guitar_Form : Form
    {
        WS_GUITAR_Client.WS_GUITARSoapClient WS = new WS_GUITAR_Client.WS_GUITARSoapClient();

        public Commander_Guitar_Form()
        {
            // chargement des données dans le listes 
            WS_GUITAR_Client.C_MICRO[] LesMics = WS.GetAllTypesMicro();
            WS_GUITAR_Client.C_TYPEBOIS[] LesTypesbois = WS.GetAllTypeBois();
            WS_GUITAR_Client.C_VIBRATO[] LesTypesVibrato = WS.GetAllTypesVibrato();

            InitializeComponent();
            
            bonCommandeGroup.Visible = false;

            // chargement des donnes dans les combo box de Types de Micro
            foreach (WS_GUITAR_Client.C_MICRO OneMic in LesMics)
            {
                Micro1Cbx.Items.Add(OneMic.Contructeur.ToString());
                Micro2Cbx.Items.Add(OneMic.Contructeur.ToString());
                Micro3Cbx.Items.Add(OneMic.Contructeur.ToString());
            }
            foreach (WS_GUITAR_Client.C_TYPEBOIS OneTypeBois in LesTypesbois)
            {
                BoisCorpsCbx.Items.Add(OneTypeBois.NomTypeBois.ToString());
                BoisToucheCbx.Items.Add(OneTypeBois.NomTypeBois.ToString());
                BoisMancheCbx.Items.Add(OneTypeBois.NomTypeBois.ToString());
            }
            foreach (WS_GUITAR_Client.C_VIBRATO OneVibrato in LesTypesVibrato)
            {
                VibratoCbx.Items.Add(OneVibrato.NomVibrato.ToString());
            }
        }

        private void CommanderGuitarBtn_Click(object sender, EventArgs e)
        {

            string NomClient = NomClientBx.Text;
            string DateCommande = DateTime.Today.ToString("dd/MM/yyyy");
            string TelClient = PhoneClientBx.Text;
            int Montant = (int)System.DateTime.Now.DayOfWeek * 15;
            string Nomguitar = NomGuitarClient.Text;
            string Micro1 = Micro1Cbx.Text;
            string Micro2 = Micro2Cbx.Text;
            string Micro3 = Micro3Cbx.Text;
            string BoisManche = BoisMancheCbx.Text;
            string BoisTouche = BoisToucheCbx.Text;
            string BoisCorps = BoisCorpsCbx.Text;
            string NomVibrato = VibratoCbx.Text;


            if (Micro2 == "Selectionner")
            {
                Micro2 = "Null";
            }
            string NouvelleCommande = WS.NouvelleCommande(NomClient, DateCommande, Montant.ToString(), TelClient);
            int idCommande = int.Parse(NouvelleCommande);
            test.Text = idCommande.ToString();
            WS.CommandeGuitar(Nomguitar, Micro1, Micro2, Micro3, BoisManche, BoisTouche, BoisCorps, NomVibrato, idCommande);
            WS_GUITAR_Client.C_BON_COMMANDE Bon_Commande = WS.GetCommandeByID(idCommande);
            List<WS_GUITAR_Client.C_BON_COMMANDE> Les_Bons = new List<WS_GUITAR_Client.C_BON_COMMANDE>();

            Les_Bons.Add(Bon_Commande);

            BonCommandeView2.DataSource = Les_Bons;

            
            bonCommandeGroup.Visible = true;
            


        }

        private void BonCommandeView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Commander_Guitar_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
