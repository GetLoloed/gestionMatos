
namespace GestionMatos.Forms
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesDeMaterielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl_Materiels = new GestionMatos.UsrControl.UserControl_Materiels();
            this.userControl_Interventions = new GestionMatos.UsrControl.UserControl_Interventions();
            this.userControl_Clients = new GestionMatos.UsrControl.UserControl_Clients();
            this.userControl_Sites = new GestionMatos.UsrControl.UserControl_Sites();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.interventionsToolStripMenuItem,
            this.materielsToolStripMenuItem,
            this.typesDeMaterielsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.sitesToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1688, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // interventionsToolStripMenuItem
            // 
            this.interventionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.interventionsToolStripMenuItem.Name = "interventionsToolStripMenuItem";
            this.interventionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.interventionsToolStripMenuItem.Text = "Interventions";
            this.interventionsToolStripMenuItem.Click += new System.EventHandler(this.interventionsToolStripMenuItem_Click);
            // 
            // materielsToolStripMenuItem
            // 
            this.materielsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.materielsToolStripMenuItem.Name = "materielsToolStripMenuItem";
            this.materielsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.materielsToolStripMenuItem.Text = "Materiels";
            this.materielsToolStripMenuItem.Click += new System.EventHandler(this.materielsToolStripMenuItem_Click);
            // 
            // typesDeMaterielsToolStripMenuItem
            // 
            this.typesDeMaterielsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.typesDeMaterielsToolStripMenuItem.Name = "typesDeMaterielsToolStripMenuItem";
            this.typesDeMaterielsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.typesDeMaterielsToolStripMenuItem.Text = "Types de materiels";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            this.sitesToolStripMenuItem.Click += new System.EventHandler(this.sitesToolStripMenuItem_Click);
            // 
            // userControl_Materiels
            // 
            this.userControl_Materiels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Materiels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userControl_Materiels.Location = new System.Drawing.Point(0, 24);
            this.userControl_Materiels.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Materiels.Name = "userControl_Materiels";
            this.userControl_Materiels.Size = new System.Drawing.Size(1688, 777);
            this.userControl_Materiels.TabIndex = 3;
            // 
            // userControl_Interventions
            // 
            this.userControl_Interventions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Interventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userControl_Interventions.Location = new System.Drawing.Point(0, 24);
            this.userControl_Interventions.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Interventions.Name = "userControl_Interventions";
            this.userControl_Interventions.Size = new System.Drawing.Size(1688, 777);
            this.userControl_Interventions.TabIndex = 2;
            // 
            // userControl_Clients
            // 
            this.userControl_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userControl_Clients.Location = new System.Drawing.Point(0, 24);
            this.userControl_Clients.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Clients.Name = "userControl_Clients";
            this.userControl_Clients.Size = new System.Drawing.Size(1688, 777);
            this.userControl_Clients.TabIndex = 4;
            // 
            // userControl_Sites
            // 
            this.userControl_Sites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Sites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userControl_Sites.Location = new System.Drawing.Point(0, 24);
            this.userControl_Sites.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Sites.Name = "userControl_Sites";
            this.userControl_Sites.Size = new System.Drawing.Size(1688, 777);
            this.userControl_Sites.TabIndex = 5;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 801);
            this.Controls.Add(this.userControl_Sites);
            this.Controls.Add(this.userControl_Clients);
            this.Controls.Add(this.userControl_Materiels);
            this.Controls.Add(this.userControl_Interventions);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesDeMaterielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private UsrControl.UserControl_Interventions userControl_Interventions;
        private UsrControl.UserControl_Materiels userControl_Materiels;
        private UsrControl.UserControl_Clients userControl_Clients;
        private UsrControl.UserControl_Sites userControl_Sites;
    }
}