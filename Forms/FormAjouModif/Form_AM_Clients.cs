using System;
using System.Windows.Forms;
using GestionMatos.Data;
using GestionMatos.Fonctions;
using GestionMatos.UsrControl;

namespace GestionMatos.Forms.FormAjouModif
{
    public partial class Form_AM_Clients : Form
    {
        private readonly UserControl_Clients _parent;
        public string id, nom, adresse;

        public Form_AM_Clients(UserControl_Clients parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                if (btnEnr.Text == "Ajouter")
                {
                    var dataClient = new Data_Clients(txtNom.Text.Trim(), txtAdresse.Text.Trim());
                    Fcts_Clients.AjouterClient(dataClient);
                }
                else if (btnEnr.Text == "Modifier")
                {
                    var dataClient = new Data_Clients(txtNom.Text.Trim(), txtAdresse.Text.Trim());
                    Fcts_Clients.ModifierClient(dataClient, id);
                }
            }

            _parent.Display();
        }

        public void ModifClient()
        {
            btnEnr.Text = "Modifier";
            txtNom.Text = nom;
            txtAdresse.Text = adresse;
        }
    }
}