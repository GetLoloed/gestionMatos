using System;
using System.Windows.Forms;
using GestionMatos.Fonctions;
using GestionMatos.Forms.FormAjouModif;

namespace GestionMatos.UsrControl
{
    public partial class UserControl_Clients : UserControl
    {
        private readonly Form_AM_Clients formAm;

        public UserControl_Clients()
        {
            InitializeComponent();
            formAm = new Form_AM_Clients(this);
        }

        public void Display()
        {
            Fcts_DB.AffichNRech("select * from client", dgvClients);
        }

        private void btnAjInter_Click(object sender, EventArgs e)
        {
            formAm.ShowDialog();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formAm.id = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                formAm.nom = dgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAm.adresse = dgvClients.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAm.ModifClient();
                formAm.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Information",
                    MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    Fcts_Clients.SupprClient(dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
        }
    }
}