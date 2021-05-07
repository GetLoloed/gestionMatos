﻿using GestionMatos.Data;
using GestionMatos.Fonctions;
using GestionMatos.UsrControl;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionMatos.Forms.FormAjouModif
{
    public partial class Form_AM_Materiels : Form
    {
        private readonly UserControl_Materiels _parent;
        public string id, nomMat, refMat, idType, idSite, idClient, dateInstal, mtbf,perime, descr;


        public Form_AM_Materiels(UserControl_Materiels parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void MultipleCb()
        {
            // Recupere les données de differentes tables pour les mettres dans une Combobox
            Fcts_DB.ComboData("select '' as id_type, '-- Choisir un Type --' as nom union select id_type, nom from typemateriel", "nom", "id_type", cbType);
            Fcts_DB.ComboData("select '' as id_site, '-- Choisir un Site --' as nom union select id_site, nom from site", "nom", "id_site", cbSite);
            Fcts_DB.ComboData("select '' as id_client, '-- Choisir un Client --' as nom union select id_client, nom from client", "nom", "id_client", cbClient);
        }

        public void ModifMat()
        {
            lblAM.Text = "Modification d'un materiel";
            btnEnr.Text = "Modifier";
            txtNom.Text = nomMat;
            txtRef.Text = refMat;
            cbType.Text = idType;
            cbClient.Text = idClient;
            cbSite.Text = idSite;
            nUpMTBF.Text = mtbf;
            txtDescr.Text = descr;
            

        }
        private void btnEnr_Click(object sender, EventArgs e)
        {
            if (btnEnr.Text == "Ajouter")
            {
                var dataMat = new Data_Materiels(txtNom.Text.Trim(), txtRef.Text.Trim(),
                    txtDescr.Text.ToString().Trim(), dtpInstal.Text.ToString().Trim(), nUpMTBF.Text.ToString().Trim(), checkbPerime.Checked.ToString(),cbType.SelectedValue.ToString(), cbSite.SelectedValue.ToString(),
                    cbClient.SelectedValue.ToString());
                Fcts_Materiels.AjoutMateriel(dataMat);
            }
            else if (btnEnr.Text == "Modifier")
            {
                var dataMat = new Data_Materiels(txtNom.Text.Trim(), txtRef.Text.Trim(),
                    txtDescr.Text.ToString().Trim(), dtpInstal.Text.ToString().Trim(), nUpMTBF.Text.ToString().Trim(),checkbPerime.Checked.ToString(), cbType.SelectedValue.ToString(), cbSite.SelectedValue.ToString(),
                    cbClient.SelectedValue.ToString());
                Fcts_Materiels.ModifMat(dataMat, id);
            }

            _parent.Display();
        }

    }
}
