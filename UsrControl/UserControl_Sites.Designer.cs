
namespace GestionMatos.UsrControl
{
    partial class UserControl_Sites
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblGestInter = new System.Windows.Forms.Label();
            this.dgvSites = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAjInter = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSites)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.pnlTop.Controls.Add(this.lblGestInter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(2224, 54);
            this.pnlTop.TabIndex = 2;
            // 
            // lblGestInter
            // 
            this.lblGestInter.AutoSize = true;
            this.lblGestInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGestInter.ForeColor = System.Drawing.Color.White;
            this.lblGestInter.Location = new System.Drawing.Point(19, 15);
            this.lblGestInter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGestInter.Name = "lblGestInter";
            this.lblGestInter.Size = new System.Drawing.Size(117, 17);
            this.lblGestInter.TabIndex = 2;
            this.lblGestInter.Text = "Gestion des sites";
            // 
            // dgvSites
            // 
            this.dgvSites.AllowUserToAddRows = false;
            this.dgvSites.AllowUserToDeleteRows = false;
            this.dgvSites.AllowUserToResizeColumns = false;
            this.dgvSites.AllowUserToResizeRows = false;
            this.dgvSites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSites.BackgroundColor = System.Drawing.Color.White;
            this.dgvSites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSites.CausesValidation = false;
            this.dgvSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSites.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSites.Location = new System.Drawing.Point(0, 97);
            this.dgvSites.Name = "dgvSites";
            this.dgvSites.RowHeadersVisible = false;
            this.dgvSites.Size = new System.Drawing.Size(2224, 752);
            this.dgvSites.TabIndex = 3;
            this.dgvSites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSites_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAjInter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2224, 43);
            this.panel2.TabIndex = 4;
            // 
            // btnAjInter
            // 
            this.btnAjInter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnAjInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjInter.ForeColor = System.Drawing.Color.White;
            this.btnAjInter.Location = new System.Drawing.Point(3, 7);
            this.btnAjInter.Name = "btnAjInter";
            this.btnAjInter.Size = new System.Drawing.Size(198, 28);
            this.btnAjInter.TabIndex = 1;
            this.btnAjInter.Text = "Ajouter nouveau site";
            this.btnAjInter.UseVisualStyleBackColor = false;
            this.btnAjInter.Click += new System.EventHandler(this.btnAjInter_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_site";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nom";
            this.Column6.HeaderText = "Nom";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "adresse";
            this.Column7.HeaderText = "Adresse";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cp";
            this.Column2.HeaderText = "Code Postal";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ville";
            this.Column3.HeaderText = "Ville";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Modifier";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Supprimer";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // UserControl_Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSites);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_Sites";
            this.Size = new System.Drawing.Size(2224, 849);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSites)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblGestInter;
        private System.Windows.Forms.DataGridView dgvSites;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}
