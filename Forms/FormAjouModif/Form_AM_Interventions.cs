using System;
using System.Windows.Forms;
using GestionMatos.Data;
using GestionMatos.Fonctions;
using GestionMatos.UsrControl;

namespace GestionMatos.Forms.FormAjouModif
{
    public partial class Form_AM_Interventions : Form
    {
        private readonly UserControl_Interventions _parent;
        public string id, idMat, dateInter, com;

        public Form_AM_Interventions(UserControl_Interventions parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        public void FillCb()
        {
            Fcts_DB.ComboData(
                "select '' as id_mat, '-- Choisir un materiel --' as nom union select id_mat, nom from materiel", "nom",
                "id_mat", cbMateriel);
        }

        public void Modifier()
        {
            lblAM.Text = "Modification intervention";
            btnEnr.Text = "Modifier";
            cbMateriel.SelectedValue = idMat;
            txtCom.Text = com;
            dtpInter.Text = dateInter;
        }

        public void Programmer()
        {
            cbMateriel.SelectedValue = idMat;
            txtCom.Text = com;
            dtpInter.Text = dateInter;
        }

        public void Clear()
        {
            txtCom.Text = dtpInter.Text = string.Empty;
            cbMateriel.SelectedValue = "";
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            if (txtCom.Text == "" || cbMateriel.SelectedValue == "" || dtpInter.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                if (btnEnr.Text == "Programmer")
                {
                    var dataInter = new Data_Interventions(dtpInter.Text.Trim(), txtCom.Text.Trim(),
                        cbMateriel.SelectedValue.ToString());
                    Fcts_Interventions.AjoutInter(dataInter);
                }
                else if (btnEnr.Text == "Modifier")
                {
                    var dataInter = new Data_Interventions(dtpInter.Text, txtCom.Text.Trim(),
                        cbMateriel.SelectedValue.ToString());
                    Fcts_Interventions.ModifInter(dataInter, id);
                }
            }

            _parent.Display();
        }
    }
}