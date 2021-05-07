using System;
using System.Drawing;
using System.Windows.Forms;
using GestionMatos.Fonctions;
using GestionMatos.Forms.FormAjouModif;


namespace GestionMatos.UsrControl
{
    public partial class UserControl_Interventions : UserControl
    {
        private readonly Form_AM_Interventions formInter;
        public UserControl_Interventions()
        {
            InitializeComponent();
            Display();
            formInter = new Form_AM_Interventions(this);
        }

        public void Display()
        {
            Fcts_DB.AffichNRech("call getInter()", dgvInter);
            Fcts_DB.AffichNRech("call Alerte_inter", dgvAlerte);
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

        public void AlerteHide()
        {
            dgvAlerte.Hide();
            btnRetour.Hide();
            dgvInter.Show();
            btnAjInter.Show();
            cbMateriel.Show();
            cbClient.Show();
            cbSite.Show();
            cbTypeMat.Show();
            btnAlertes.Show();
        }

        
        private void dgvInter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Fcts_Interventions.Intervenu(dgvInter.Rows[e.RowIndex].Cells[3].Value.ToString());
                Display();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                formInter.id = dgvInter.Rows[e.RowIndex].Cells[3].Value.ToString();
                formInter.idMat = dgvInter.Rows[e.RowIndex].Cells[4].Value.ToString();
                formInter.dateInter = dgvInter.Rows[e.RowIndex].Cells[5].Value.ToString();
                formInter.com = dgvInter.Rows[e.RowIndex].Cells[6].Value.ToString();
                formInter.FillCb();
                formInter.Modifier();
                formInter.ShowDialog();
                return;
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette intervention ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes )
                {
                    Fcts_Interventions.SupprInter(dgvInter.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                    return;
                }
            }
        }

        private void btnAjInter_Click(object sender, EventArgs e)
        {
            formInter.Clear();
            formInter.FillCb();
            formInter.ShowDialog();
        }

        private void btnAlertes_Click(object sender, EventArgs e)
        {
            lblGestInter.Text = "Alertes MTBF";

            dgvAlerte.Show();
            btnRetour.Show();
            dgvInter.Hide();
            btnAjInter.Hide();
            cbMateriel.Hide();
            cbClient.Hide();
            cbSite.Hide();
            cbTypeMat.Hide();
            btnAlertes.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            lblGestInter.Text = "Gestion des interventions";

            dgvAlerte.Hide();
            btnRetour.Hide();
            dgvInter.Show();
            btnAjInter.Show();
            cbMateriel.Show();
            cbClient.Show();
            cbSite.Show();
            cbTypeMat.Show();
            btnAlertes.Show();
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            Fcts_DB.AffichNRech(
                "select i.id_intervention, m.id_mat, i.dateInter, i.com, m.nom, t.nom as nomType, c.nom as nomClient, s.nom as nomSite,if(i.finie = 'True', 'oui', 'non') as intervenu  from materiel m left join intervention i on m.id_mat = i.id_mat left join client c on c.id_client = m.id_client left join site s on m.id_site = s.id_site left join typemateriel t on m.id_type = t.id_type where m.id_client like '%" +
                cbClient.SelectedValue + "' and m.id_mat like '%" + cbMateriel.SelectedValue +
                "' and m.id_type like '%" + cbTypeMat.SelectedValue + "' and m.id_site like '%" +
                cbSite.SelectedValue + "'", dgvInter);
        }

        private void btnReini_Click(object sender, EventArgs e)
        {
            cbMateriel.SelectedValue = cbSite.SelectedValue = cbTypeMat.SelectedValue = cbClient.SelectedValue = "";
            Display();
        }

        private void dgvAlerte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formInter.id = dgvInter.Rows[e.RowIndex].Cells[3].Value.ToString();
                formInter.dateInter = dgvInter.Rows[e.RowIndex].Cells[5].Value.ToString();
                formInter.com = dgvInter.Rows[e.RowIndex].Cells[6].Value.ToString();
                formInter.FillCb();
                formInter.Programmer();
                formInter.ShowDialog();
                return;
            }
        }
    }
}
