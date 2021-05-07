using GestionMatos.Fonctions;
using GestionMatos.Forms.FormAjouModif;
using System.Windows.Forms;

namespace GestionMatos.UsrControl
{
    public partial class UserControl_Materiels : UserControl
    {
        private readonly Form_AM_Materiels formAm;
        public UserControl_Materiels()
        {
            InitializeComponent();
            formAm = new Form_AM_Materiels(this);
        }

        public void Display()
        {
            Fcts_DB.AffichNRech("call getMat()", dgvMat);
            Fcts_DB.ComboData(
                "SELECT '' as id_client, '-- Choisir un client --' AS nom UNION SELECT id_client, nom FROM client ORDER BY nom",
                "nom", "id_client", cbClient);
            Fcts_DB.ComboData(
                "SELECT '' as id_type, '-- Choisir un type --' AS nom UNION SELECT id_type, nom FROM typemateriel ORDER BY nom",
                "nom", "id_type", cbTypeMat);
            Fcts_DB.ComboData(
                "SELECT '' as id_mat, '-- Choisir un materiel --' AS nom UNION SELECT id_mat, nom FROM materiel ORDER BY nom",
                "nom", "id_mat", cbMateriel);
            Fcts_DB.ComboData(
                "SELECT '' as id_site, '-- Choisir un site --' AS nom UNION SELECT id_site, nom FROM site ORDER BY nom",
                "nom", "id_site", cbSite);
        }

        private void dgvMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Fcts_Materiels.EstIntervenu(dgvMat.Rows[e.RowIndex].Cells[3].Value.ToString());
                Display();
                return;
            }
            else if (e.ColumnIndex == 1)
            {
                formAm.id = dgvMat.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAm.nomMat = dgvMat.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAm.refMat = dgvMat.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAm.descr = dgvMat.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAm.dateInstal = dgvMat.Rows[e.RowIndex].Cells[7].Value.ToString();
                formAm.mtbf = dgvMat.Rows[e.RowIndex].Cells[8].Value.ToString();
                formAm.perime = dgvMat.Rows[e.RowIndex].Cells[9].Value.ToString();
                formAm.idType = dgvMat.Rows[e.RowIndex].Cells[10].Value.ToString();
                formAm.idSite = dgvMat.Rows[e.RowIndex].Cells[11].Value.ToString();
                formAm.idClient = dgvMat.Rows[e.RowIndex].Cells[12].Value.ToString();
                formAm.MultipleCb();
                formAm.ModifMat();
                formAm.ShowDialog();
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce materiel ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fcts_Materiels.SupprMateriel(dgvMat.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
            }
        }

        private void btnAjMat_Click(object sender, System.EventArgs e)
        {
            formAm.MultipleCb();
            formAm.ShowDialog();
        }
    }
}
