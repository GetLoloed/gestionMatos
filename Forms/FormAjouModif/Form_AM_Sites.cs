using System;
using System.Windows.Forms;
using GestionMatos.Data;
using GestionMatos.Fonctions;
using GestionMatos.UsrControl;

namespace GestionMatos.Forms.FormAjouModif
{
    public partial class Form_AM_Sites : Form
    {
        private readonly UserControl_Sites _parent;
        public string id, nom, adresse, cp, ville;

        public Form_AM_Sites(UserControl_Sites parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtAdresse.Text = txtNom.Text = txtCp.Text = txtVille.Text = string.Empty;
        }

        public void ModifSite()
        {
            lblAM.Text = "Modification d'un site";
            btnEnr.Text = "Modifier";
            txtNom.Text = nom;
            txtAdresse.Text = adresse;
            txtVille.Text = ville;
            txtCp.Text = cp;
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtCp.Text == "" || txtNom.Text == "" || txtVille.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                if (btnEnr.Text == "Ajouter")
                {
                    var dataSite = new Data_Sites(txtNom.Text.Trim(), txtAdresse.Text.Trim(), txtCp.Text.Trim(),
                        txtVille.Text.Trim());
                    Fcts_Sites.AjouterSite(dataSite);
                }
                else if (btnEnr.Text == "Modifier")
                {
                    var dataSite = new Data_Sites(txtNom.Text.Trim(), txtAdresse.Text.Trim(), txtCp.Text.Trim(),
                        txtVille.Text.Trim());
                    Fcts_Sites.ModifierSite(dataSite, id);
                }
            }

            _parent.Display();
        }
    }
}