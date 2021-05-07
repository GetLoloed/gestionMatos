using System;
using System.Windows.Forms;
using GestionMatos.Fonctions;
using GestionMatos.Forms.FormAjouModif;

namespace GestionMatos.UsrControl
{
    public partial class UserControl_Sites : UserControl
    {
        private readonly Form_AM_Sites formAm;

        public UserControl_Sites()
        {
            InitializeComponent();
            formAm = new Form_AM_Sites(this);
        }

        public void Display()
        {
            Fcts_DB.AffichNRech("select * from site", dgvSites);
        }

        private void btnAjInter_Click(object sender, EventArgs e)
        {
            formAm.Clear();
            formAm.ShowDialog();
        }

        private void dgvSites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formAm.id = dgvSites.Rows[e.RowIndex].Cells[2].Value.ToString();
                formAm.nom = dgvSites.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAm.adresse = dgvSites.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAm.cp = dgvSites.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAm.ville = dgvSites.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAm.ModifSite();
                formAm.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez vous vraiment le site " + formAm.nom + " ?", "Information",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fcts_Sites.SupprSite(dgvSites.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
        }
    }
}