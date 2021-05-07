using System;
using System.Windows.Forms;
using GestionMatos.Fonctions;
using GestionMatos.Forms.FormAjouModif;

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
            }
            else if (e.ColumnIndex == 1)
            {
                formAm.id = dgvMat.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAm.nomMat = dgvMat.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAm.refMat = dgvMat.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAm.descr = dgvMat.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAm.dateInstal = dgvMat.Rows[e.RowIndex].Cells[7].Value.ToString();
                formAm.mtbf = dgvMat.Rows[e.RowIndex].Cells[8].Value.ToString();
                formAm.perime = dgvMat.Rows[e.RowIndex].Cells[11].Value.ToString();
                formAm.idType = dgvMat.Rows[e.RowIndex].Cells[12].Value.ToString();
                formAm.idSite = dgvMat.Rows[e.RowIndex].Cells[13].Value.ToString();
                formAm.idClient = dgvMat.Rows[e.RowIndex].Cells[14].Value.ToString();
                formAm.MultipleCb();
                formAm.ModifMat();
                formAm.ShowDialog();
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce materiel ?", "Information",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fcts_Materiels.SupprMateriel(dgvMat.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
            }
        }

        private void btnAjMat_Click(object sender, EventArgs e)
        {
            formAm.MultipleCb();
            formAm.ShowDialog();
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            Fcts_DB.AffichNRech(
                "select m.id_mat,m.nom,m.referenece,m.descr,m.date_instal,m.mtbf,if(isnull((SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat = m.id_mat order by intervention.dateInter desc limit 1)), m.date_instal, (SELECT intervention.dateInter FROM materiel as m LEFT JOIN intervention ON intervention.id_mat = m.id_mat WHERE m.id_mat = m.id_mat order by intervention.dateInter desc limit 1)) as dateDernInter, ADDDATE(if(isnull((SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat = m.id_mat order by intervention.dateInter desc limit 1)), m.date_instal, (SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat = m.id_mat order by intervention.dateInter desc limit 1)),m.mtbf) as Datelimite, if(perime = 'True', 'oui', 'non') as perimeON, t.nom  as nomType,s.nom as nomSite, c.nom as nomClient from materiel m left join typemateriel t on t.id_type = m.id_type left join site s on s.id_site = m.id_site left join client c on c.id_client = m.id_client WHERE m.id_mat LIKE '%" +
                cbMateriel.SelectedValue + "' and c.id_client like '%" + cbClient.SelectedValue +
                "' and t.id_type like  '%" + cbTypeMat.SelectedValue + "' and s.id_site like '%" +
                cbSite.SelectedValue + "' order by perimeON, nom", dgvMat);
        }

        private void btnReini_Click(object sender, EventArgs e)
        {
            cbMateriel.SelectedValue = cbSite.SelectedValue = cbTypeMat.SelectedValue = cbClient.SelectedValue = "";
            Display();
        }
    }
}