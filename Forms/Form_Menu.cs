using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Interventions.Hide();
        }

        private void interventionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_Interventions.Show();
            userControl_Interventions.Display();
        }

    }
}
