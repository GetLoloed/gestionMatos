
namespace GestionMatos.UsrControl
{
    partial class UserControl_Interventions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Interventions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGestInter = new System.Windows.Forms.Label();
            this.btnAjInter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReini = new System.Windows.Forms.Button();
            this.btnRech = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.cbTypeMat = new System.Windows.Forms.ComboBox();
            this.cbMateriel = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnAlertes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAlerte = new System.Windows.Forms.DataGridView();
            this.dgvInter = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.lblGestInter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblGestInter
            // 
            this.lblGestInter.AutoSize = true;
            this.lblGestInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGestInter.ForeColor = System.Drawing.Color.White;
            this.lblGestInter.Location = new System.Drawing.Point(14, 12);
            this.lblGestInter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestInter.Name = "lblGestInter";
            this.lblGestInter.Size = new System.Drawing.Size(169, 17);
            this.lblGestInter.TabIndex = 2;
            this.lblGestInter.Text = "Gestion des interventions";
            // 
            // btnAjInter
            // 
            this.btnAjInter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnAjInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjInter.ForeColor = System.Drawing.Color.White;
            this.btnAjInter.Location = new System.Drawing.Point(3, 7);
            this.btnAjInter.Name = "btnAjInter";
            this.btnAjInter.Size = new System.Drawing.Size(319, 28);
            this.btnAjInter.TabIndex = 1;
            this.btnAjInter.Text = "Programmer une nouvelle intervention";
            this.btnAjInter.UseVisualStyleBackColor = false;
            this.btnAjInter.Click += new System.EventHandler(this.btnAjInter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReini);
            this.panel2.Controls.Add(this.btnRech);
            this.panel2.Controls.Add(this.btnRetour);
            this.panel2.Controls.Add(this.cbSite);
            this.panel2.Controls.Add(this.cbTypeMat);
            this.panel2.Controls.Add(this.cbMateriel);
            this.panel2.Controls.Add(this.cbClient);
            this.panel2.Controls.Add(this.btnAlertes);
            this.panel2.Controls.Add(this.btnAjInter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1668, 43);
            this.panel2.TabIndex = 2;
            // 
            // btnReini
            // 
            this.btnReini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnReini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReini.Image = ((System.Drawing.Image)(resources.GetObject("btnReini.Image")));
            this.btnReini.Location = new System.Drawing.Point(1383, 12);
            this.btnReini.Name = "btnReini";
            this.btnReini.Size = new System.Drawing.Size(37, 23);
            this.btnReini.TabIndex = 9;
            this.btnReini.UseVisualStyleBackColor = false;
            this.btnReini.Click += new System.EventHandler(this.btnReini_Click);
            // 
            // btnRech
            // 
            this.btnRech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRech.Image = ((System.Drawing.Image)(resources.GetObject("btnRech.Image")));
            this.btnRech.Location = new System.Drawing.Point(1344, 12);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(33, 23);
            this.btnRech.TabIndex = 8;
            this.btnRech.UseVisualStyleBackColor = false;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(3, 7);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(80, 28);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(1127, 10);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(211, 24);
            this.cbSite.TabIndex = 6;
            // 
            // cbTypeMat
            // 
            this.cbTypeMat.FormattingEnabled = true;
            this.cbTypeMat.Location = new System.Drawing.Point(910, 10);
            this.cbTypeMat.Name = "cbTypeMat";
            this.cbTypeMat.Size = new System.Drawing.Size(211, 24);
            this.cbTypeMat.TabIndex = 5;
            // 
            // cbMateriel
            // 
            this.cbMateriel.FormattingEnabled = true;
            this.cbMateriel.Location = new System.Drawing.Point(693, 10);
            this.cbMateriel.Name = "cbMateriel";
            this.cbMateriel.Size = new System.Drawing.Size(211, 24);
            this.cbMateriel.TabIndex = 4;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(476, 10);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(211, 24);
            this.cbClient.TabIndex = 3;
            // 
            // btnAlertes
            // 
            this.btnAlertes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnAlertes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertes.ForeColor = System.Drawing.Color.White;
            this.btnAlertes.Location = new System.Drawing.Point(328, 7);
            this.btnAlertes.Name = "btnAlertes";
            this.btnAlertes.Size = new System.Drawing.Size(142, 28);
            this.btnAlertes.TabIndex = 2;
            this.btnAlertes.Text = "Alertes MTBFS";
            this.btnAlertes.UseVisualStyleBackColor = false;
            this.btnAlertes.Click += new System.EventHandler(this.btnAlertes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInter);
            this.panel3.Controls.Add(this.dgvAlerte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1668, 603);
            this.panel3.TabIndex = 3;
            // 
            // dgvAlerte
            // 
            this.dgvAlerte.AllowUserToAddRows = false;
            this.dgvAlerte.AllowUserToDeleteRows = false;
            this.dgvAlerte.AllowUserToResizeColumns = false;
            this.dgvAlerte.AllowUserToResizeRows = false;
            this.dgvAlerte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlerte.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlerte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlerte.CausesValidation = false;
            this.dgvAlerte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dgvAlerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlerte.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlerte.Location = new System.Drawing.Point(0, 0);
            this.dgvAlerte.Name = "dgvAlerte";
            this.dgvAlerte.RowHeadersVisible = false;
            this.dgvAlerte.Size = new System.Drawing.Size(1668, 603);
            this.dgvAlerte.TabIndex = 1;
            this.dgvAlerte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlerte_CellClick);
            // 
            // dgvInter
            // 
            this.dgvInter.AllowUserToAddRows = false;
            this.dgvInter.AllowUserToDeleteRows = false;
            this.dgvInter.AllowUserToResizeColumns = false;
            this.dgvInter.AllowUserToResizeRows = false;
            this.dgvInter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInter.BackgroundColor = System.Drawing.Color.White;
            this.dgvInter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInter.CausesValidation = false;
            this.dgvInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column12,
            this.Column9,
            this.Column10});
            this.dgvInter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInter.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInter.Location = new System.Drawing.Point(0, 0);
            this.dgvInter.Name = "dgvInter";
            this.dgvInter.RowHeadersVisible = false;
            this.dgvInter.Size = new System.Drawing.Size(1668, 603);
            this.dgvInter.TabIndex = 0;
            this.dgvInter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInter_CellClick);
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "id_mat";
            this.Column13.HeaderText = "ID";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "nom";
            this.Column14.HeaderText = "Nom du materiel";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "nom1";
            this.Column15.HeaderText = "Nom du client";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "nom2";
            this.Column16.HeaderText = "Nom du site";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "dateDernInter";
            this.Column17.HeaderText = "Date derniere intervention";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Datelimite";
            this.Column18.HeaderText = "date limite avant intervention";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Column19.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column19.HeaderText = "";
            this.Column19.Name = "Column19";
            this.Column19.Text = "Programmer";
            this.Column19.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_intervention";
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "id_mat";
            this.Column11.HeaderText = "id mat";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dateInter";
            this.Column2.HeaderText = "Date intervention";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "com";
            this.Column3.HeaderText = "Commentaire";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nom";
            this.Column4.HeaderText = "Nom materiel";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nomType";
            this.Column5.HeaderText = "Type materiel";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nomClient";
            this.Column6.HeaderText = "Nom client";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nomSite";
            this.Column7.HeaderText = "Nom site";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "intervenu";
            this.Column8.HeaderText = "Intervenu ?";
            this.Column8.Name = "Column8";
            // 
            // Column12
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.Text = "Intervenu";
            this.Column12.UseColumnTextForButtonValue = true;
            // 
            // Column9
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.Text = "Modifier";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Text = "Supprimer";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // UserControl_Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Interventions";
            this.Size = new System.Drawing.Size(1668, 690);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestInter;
        private System.Windows.Forms.Button btnAjInter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInter;
        private System.Windows.Forms.Button btnAlertes;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbTypeMat;
        private System.Windows.Forms.ComboBox cbMateriel;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.DataGridView dgvAlerte;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnReini;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewButtonColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}
