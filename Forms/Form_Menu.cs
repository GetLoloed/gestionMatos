using System;
using System.Windows.Forms;
using GestionMatos.UsrControl;

namespace GestionMatos.Forms
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            hideAll();
        }

        private void hideAll()
        {
            userControl_Interventions.Hide();
            userControl_Materiels.Hide();
            userControl_Clients.Hide();
            userControl_Sites.Hide();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void interventionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Interventions.AlerteHide();
            userControl_Interventions.Show();
            userControl_Interventions.Display();

            userControl_Materiels.Hide();
            userControl_Clients.Hide();
            userControl_Sites.Hide();
            
        }

        private void materielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Materiels.Show();
            userControl_Materiels.Display();

            userControl_Interventions.Hide();
            userControl_Clients.Hide();
            userControl_Sites.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Clients.Show();
            userControl_Clients.Display();

            userControl_Interventions.Hide();
            userControl_Materiels.Hide();
            userControl_Sites.Hide();
        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Sites.Show();
            userControl_Sites.Display();

            userControl_Clients.Hide();
            userControl_Interventions.Hide();
            userControl_Materiels.Hide();
        }
    }
}
