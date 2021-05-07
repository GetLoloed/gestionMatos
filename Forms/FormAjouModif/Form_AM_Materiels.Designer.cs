
namespace GestionMatos.Forms.FormAjouModif
{
    partial class Form_AM_Materiels
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAM = new System.Windows.Forms.Label();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.checkbPerime = new System.Windows.Forms.CheckBox();
            this.lblDateInsta = new System.Windows.Forms.Label();
            this.dtpInstal = new System.Windows.Forms.DateTimePicker();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblMTBF = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.RichTextBox();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nUpMTBF = new System.Windows.Forms.NumericUpDown();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnEnr = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpMTBF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.pnlTop.Controls.Add(this.lblAM);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(537, 54);
            this.pnlTop.TabIndex = 2;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAM.ForeColor = System.Drawing.Color.White;
            this.lblAM.Location = new System.Drawing.Point(16, 11);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(182, 25);
            this.lblAM.TabIndex = 7;
            this.lblAM.Text = "Ajouts d\'un materiel";
            // 
            // pnlMid
            // 
            this.pnlMid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.Controls.Add(this.checkbPerime);
            this.pnlMid.Controls.Add(this.lblDateInsta);
            this.pnlMid.Controls.Add(this.dtpInstal);
            this.pnlMid.Controls.Add(this.lblDescr);
            this.pnlMid.Controls.Add(this.lblMTBF);
            this.pnlMid.Controls.Add(this.lblClient);
            this.pnlMid.Controls.Add(this.lblSite);
            this.pnlMid.Controls.Add(this.lblType);
            this.pnlMid.Controls.Add(this.lblRef);
            this.pnlMid.Controls.Add(this.lblNom);
            this.pnlMid.Controls.Add(this.txtDescr);
            this.pnlMid.Controls.Add(this.cbSite);
            this.pnlMid.Controls.Add(this.cbClient);
            this.pnlMid.Controls.Add(this.cbType);
            this.pnlMid.Controls.Add(this.nUpMTBF);
            this.pnlMid.Controls.Add(this.txtRef);
            this.pnlMid.Controls.Add(this.txtNom);
            this.pnlMid.Location = new System.Drawing.Point(16, 77);
            this.pnlMid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(505, 354);
            this.pnlMid.TabIndex = 3;
            // 
            // checkbPerime
            // 
            this.checkbPerime.AutoSize = true;
            this.checkbPerime.Location = new System.Drawing.Point(345, 168);
            this.checkbPerime.Name = "checkbPerime";
            this.checkbPerime.Size = new System.Drawing.Size(141, 21);
            this.checkbPerime.TabIndex = 16;
            this.checkbPerime.Text = "Cocher si  perimé.";
            this.checkbPerime.UseVisualStyleBackColor = true;
            // 
            // lblDateInsta
            // 
            this.lblDateInsta.AutoSize = true;
            this.lblDateInsta.Location = new System.Drawing.Point(171, 141);
            this.lblDateInsta.Name = "lblDateInsta";
            this.lblDateInsta.Size = new System.Drawing.Size(128, 17);
            this.lblDateInsta.TabIndex = 15;
            this.lblDateInsta.Text = "Date d\'installation :";
            // 
            // dtpInstal
            // 
            this.dtpInstal.CustomFormat = "yyyy-MM-dd";
            this.dtpInstal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInstal.Location = new System.Drawing.Point(174, 164);
            this.dtpInstal.Name = "dtpInstal";
            this.dtpInstal.Size = new System.Drawing.Size(158, 23);
            this.dtpInstal.TabIndex = 8;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(3, 198);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(161, 17);
            this.lblDescr.TabIndex = 14;
            this.lblDescr.Text = "Description du materiel :";
            // 
            // lblMTBF
            // 
            this.lblMTBF.AutoSize = true;
            this.lblMTBF.Location = new System.Drawing.Point(3, 140);
            this.lblMTBF.Name = "lblMTBF";
            this.lblMTBF.Size = new System.Drawing.Size(118, 17);
            this.lblMTBF.TabIndex = 13;
            this.lblMTBF.Text = "MTBF (en jours) :";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(336, 77);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(51, 17);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "Client :";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(171, 77);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(40, 17);
            this.lblSite.TabIndex = 11;
            this.lblSite.Text = "Site :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 77);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(122, 17);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type de materiel :";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(253, 12);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(82, 17);
            this.lblRef.TabIndex = 9;
            this.lblRef.Text = "Reference :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(4, 219);
            this.txtDescr.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(495, 123);
            this.txtDescr.TabIndex = 7;
            this.txtDescr.Text = "";
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(173, 98);
            this.cbSite.Margin = new System.Windows.Forms.Padding(4);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(160, 24);
            this.cbSite.TabIndex = 6;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(339, 98);
            this.cbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(160, 24);
            this.cbClient.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(4, 98);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(160, 24);
            this.cbType.TabIndex = 4;
            // 
            // nUpMTBF
            // 
            this.nUpMTBF.Location = new System.Drawing.Point(5, 161);
            this.nUpMTBF.Margin = new System.Windows.Forms.Padding(4);
            this.nUpMTBF.Name = "nUpMTBF";
            this.nUpMTBF.Size = new System.Drawing.Size(160, 23);
            this.nUpMTBF.TabIndex = 2;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(256, 33);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(243, 23);
            this.txtRef.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(4, 33);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(243, 23);
            this.txtNom.TabIndex = 0;
            // 
            // btnEnr
            // 
            this.btnEnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnEnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnr.ForeColor = System.Drawing.Color.White;
            this.btnEnr.Location = new System.Drawing.Point(87, 437);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(369, 26);
            this.btnEnr.TabIndex = 4;
            this.btnEnr.Text = "Ajouter";
            this.btnEnr.UseVisualStyleBackColor = false;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // Form_AM_Materiels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 474);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AM_Materiels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiels";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpMTBF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.NumericUpDown nUpMTBF;
        private System.Windows.Forms.RichTextBox txtDescr;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblMTBF;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DateTimePicker dtpInstal;
        private System.Windows.Forms.Label lblDateInsta;
        private System.Windows.Forms.CheckBox checkbPerime;
    }
}