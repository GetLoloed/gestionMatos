
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGestInter = new System.Windows.Forms.Label();
            this.btnAjInter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.cbTypeMat = new System.Windows.Forms.ComboBox();
            this.cbMateriel = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnAlertes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInter = new System.Windows.Forms.DataGridView();
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1668, 603);
            this.panel3.TabIndex = 3;
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
            this.Column12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.Text = "Intervenu";
            this.Column12.UseColumnTextForButtonValue = true;
            // 
            // Column9
            // 
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.Text = "Modifier";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle1;
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
