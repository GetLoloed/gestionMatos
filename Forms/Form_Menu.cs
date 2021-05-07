using System;
using System.Windows.Forms;

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
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void interventionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Interventions.Show();
            userControl_Interventions.Display();
            userControl_Materiels.Hide();
            userControl_Clients.Hide();
            
        }

        private void materielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Materiels.Show();
            userControl_Materiels.Display();
            userControl_Interventions.Hide();
            userControl_Clients.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Clients.Show();
            userControl_Clients.Display();
            userControl_Interventions.Hide();
            userControl_Materiels.Hide();
        }
    }
}
