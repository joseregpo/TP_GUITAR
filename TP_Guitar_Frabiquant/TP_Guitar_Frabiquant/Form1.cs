using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Guitar_Frabiquant
{
    public partial class EditionEntreprise : Form
    {
        WS_Guitar.WS_GUITARSoapClient WS = new WS_Guitar.WS_GUITARSoapClient();
        public EditionEntreprise()
        {
            InitializeComponent();
        }
  
        private void MontrerBtn_Click(object sender, EventArgs e)
        {
            switch (ItemToShowCbx.Text)
            {
                case "Commandes" :
                        WS_Guitar.C_BON_COMMANDE[] LesCommandes = WS.GetAllCommandesFaites();
                        GridCommandes.DataSource = LesCommandes;
                break;
                case "Constructeur du Micro":
                        ItemsList.Items.Clear();
                        WS_Guitar.C_MICRO[] LesMics = WS.GetAllTypesMicro();
                        foreach (WS_Guitar.C_MICRO OneMic in LesMics)
                        {
                            ItemsList.Items.Add(OneMic.Contructeur.ToString());
                        }
                break;
                case "Type de Bois":
                        ItemsList.Items.Clear();
                        WS_Guitar.C_TYPEBOIS[] LesTypesbois = WS.GetAllTypeBois();
                        foreach (WS_Guitar.C_TYPEBOIS OneTypeBois in LesTypesbois)
                        {
                            ItemsList.Items.Add(OneTypeBois.NomTypeBois.ToString());
                        }
                break;
                case "Type de Vibrato":
                        ItemsList.Items.Clear();
                        WS_Guitar.C_VIBRATO[] LesTypesVibrato = WS.GetAllTypesVibrato();
                        foreach (WS_Guitar.C_VIBRATO OneVibrato in LesTypesVibrato)
                        {
                            ItemsList.Items.Add(OneVibrato.NomVibrato.ToString());
                        }
                break;
            }
           
            
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string El = InputElement.Text;
            if(VibratoCircle.Checked == true)
            {
                WS.AjoutVibratoByName(El);
                ItemsList.Items.Clear();
            }
            else if(MicroCircle.Checked == true)
            {
                WS.AjoutConstructeurMicroByName(El);
                ItemsList.Items.Clear();
            }
            else if(TypeBoisCircle.Checked == true)
            {
                WS.AjoutTypeBoisByName(El);
                ItemsList.Items.Clear();
            }
        }

        private void EffacerEl_Click(object sender, EventArgs e)
        {
            string El = ItemsList.GetItemText(ItemsList.SelectedItem).ToString();
            if (ItemToShowCbx.Text == "Constructeur du Micro")
            {
                WS.EraseMicroByConstructeur(El);
                ItemsList.Items.Clear();
            }
            else if (ItemToShowCbx.Text == "Type de Bois")
            {
                WS.EraseTypeBoisByName(El);
                ItemsList.Items.Clear();
            }
            else if (ItemToShowCbx.Text == "Type de Vibrato")
            {
                WS.EraseVibratoByName(El);
                ItemsList.Items.Clear();
            }
        }

        private void EffacerCommandeBtn_Click(object sender, EventArgs e)
        {
            var itemToDelete = (WS_Guitar.C_BON_COMMANDE)GridCommandes.SelectedRows[0].DataBoundItem;
            WS.EraseCommandeById(int.Parse(itemToDelete.NroCommande.ToString()));
            WS_Guitar.C_BON_COMMANDE[] LesCommandes = WS.GetAllCommandesFaites();
            GridCommandes.DataSource = LesCommandes;
        }
    }
}
