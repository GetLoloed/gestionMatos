
namespace GestionMatos.UsrControl
{
    partial class UserControl_Materiels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Materiels));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGestInter = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnReini = new System.Windows.Forms.Button();
            this.btnRech = new System.Windows.Forms.Button();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.cbTypeMat = new System.Windows.Forms.ComboBox();
            this.cbMateriel = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnAjMat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestInter
            // 
            this.lblGestInter.AutoSize = true;
            this.lblGestInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGestInter.ForeColor = System.Drawing.Color.White;
            this.lblGestInter.Location = new System.Drawing.Point(14, 12);
            this.lblGestInter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestInter.Name = "lblGestInter";
            this.lblGestInter.Size = new System.Drawing.Size(145, 17);
            this.lblGestInter.TabIndex = 2;
            this.lblGestInter.Text = "Gestion des materiels";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.pnlTop.Controls.Add(this.lblGestInter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1668, 44);
            this.pnlTop.TabIndex = 1;
            // 
            // dgvMat
            // 
            this.dgvMat.AllowUserToAddRows = false;
            this.dgvMat.AllowUserToDeleteRows = false;
            this.dgvMat.AllowUserToResizeColumns = false;
            this.dgvMat.AllowUserToResizeRows = false;
            this.dgvMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMat.BackgroundColor = System.Drawing.Color.White;
            this.dgvMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMat.CausesValidation = false;
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column14,
            this.Column15,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMat.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMat.Location = new System.Drawing.Point(0, 87);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.RowHeadersVisible = false;
            this.dgvMat.Size = new System.Drawing.Size(1668, 603);
            this.dgvMat.TabIndex = 2;
            this.dgvMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMat_CellClick);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnReini);
            this.pnlActions.Controls.Add(this.btnRech);
            this.pnlActions.Controls.Add(this.cbSite);
            this.pnlActions.Controls.Add(this.cbTypeMat);
            this.pnlActions.Controls.Add(this.cbMateriel);
            this.pnlActions.Controls.Add(this.cbClient);
            this.pnlActions.Controls.Add(this.btnAjMat);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 44);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1668, 43);
            this.pnlActions.TabIndex = 3;
            // 
            // btnReini
            // 
            this.btnReini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnReini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReini.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReini.Image = ((System.Drawing.Image)(resources.GetObject("btnReini.Image")));
            this.btnReini.Location = new System.Drawing.Point(1074, 11);
            this.btnReini.Name = "btnReini";
            this.btnReini.Size = new System.Drawing.Size(29, 23);
            this.btnReini.TabIndex = 7;
            this.btnReini.UseVisualStyleBackColor = false;
            this.btnReini.Click += new System.EventHandler(this.btnReini_Click);
            // 
            // btnRech
            // 
            this.btnRech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRech.Image = ((System.Drawing.Image)(resources.GetObject("btnRech.Image")));
            this.btnRech.Location = new System.Drawing.Point(1033, 10);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(35, 24);
            this.btnRech.TabIndex = 4;
            this.btnRech.UseVisualStyleBackColor = false;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(816, 10);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(211, 24);
            this.cbSite.TabIndex = 6;
            // 
            // cbTypeMat
            // 
            this.cbTypeMat.FormattingEnabled = true;
            this.cbTypeMat.Location = new System.Drawing.Point(599, 10);
            this.cbTypeMat.Name = "cbTypeMat";
            this.cbTypeMat.Size = new System.Drawing.Size(211, 24);
            this.cbTypeMat.TabIndex = 5;
            // 
            // cbMateriel
            // 
            this.cbMateriel.FormattingEnabled = true;
            this.cbMateriel.Location = new System.Drawing.Point(382, 10);
            this.cbMateriel.Name = "cbMateriel";
            this.cbMateriel.Size = new System.Drawing.Size(211, 24);
            this.cbMateriel.TabIndex = 4;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(165, 10);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(211, 24);
            this.cbClient.TabIndex = 3;
            // 
            // btnAjMat
            // 
            this.btnAjMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnAjMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjMat.ForeColor = System.Drawing.Color.White;
            this.btnAjMat.Location = new System.Drawing.Point(3, 7);
            this.btnAjMat.Name = "btnAjMat";
            this.btnAjMat.Size = new System.Drawing.Size(156, 28);
            this.btnAjMat.TabIndex = 1;
            this.btnAjMat.Text = "Ajouter un materiel";
            this.btnAjMat.UseVisualStyleBackColor = false;
            this.btnAjMat.Click += new System.EventHandler(this.btnAjMat_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_mat";
            this.Column1.HeaderText = "Id du materiel";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nom";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "referenece";
            this.Column3.HeaderText = "Reference";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "descr";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "date_instal";
            this.Column5.HeaderText = "Date installation";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mtbf";
            this.Column6.HeaderText = "MTBF (en jours)";
            this.Column6.Name = "Column6";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "dateDernInter";
            this.Column14.HeaderText = "Date derniere intervention";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Datelimite";
            this.Column15.HeaderText = "Date limite ";
            this.Column15.Name = "Column15";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "perimeON";
            this.Column7.HeaderText = "Perimé ?";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "nomType";
            this.Column8.HeaderText = "Type ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "nomSite";
            this.Column9.HeaderText = "Site";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "nomClient";
            this.Column10.HeaderText = "Client";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.Column11.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Text = "Périmé ";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // Column12
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.Text = "Modifier";
            this.Column12.UseColumnTextForButtonValue = true;
            // 
            // Column13
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.Column13.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column13.HeaderText = "";
            this.Column13.Name = "Column13";
            this.Column13.Text = "Supprimer";
            this.Column13.UseColumnTextForButtonValue = true;
            // 
            // UserControl_Materiels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Materiels";
            this.Size = new System.Drawing.Size(1668, 690);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGestInter;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.ComboBox cbTypeMat;
        private System.Windows.Forms.ComboBox cbMateriel;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Button btnAjMat;
        private System.Windows.Forms.Button btnReini;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.DataGridViewButtonColumn Column13;
    }
}
