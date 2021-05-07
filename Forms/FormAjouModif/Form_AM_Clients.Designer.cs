
namespace GestionMatos.Forms.FormAjouModif
{
    partial class Form_AM_Clients
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnEnr = new System.Windows.Forms.Button();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.pnlTop.Controls.Add(this.lblAM);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(289, 68);
            this.pnlTop.TabIndex = 1;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAM.ForeColor = System.Drawing.Color.White;
            this.lblAM.Location = new System.Drawing.Point(17, 22);
            this.lblAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(159, 25);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Ajouts d\'un client";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(22, 122);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(244, 23);
            this.txtNom.TabIndex = 2;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(22, 184);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(244, 23);
            this.txtAdresse.TabIndex = 3;
            // 
            // btnEnr
            // 
            this.btnEnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnEnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnr.ForeColor = System.Drawing.Color.White;
            this.btnEnr.Location = new System.Drawing.Point(57, 239);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(181, 26);
            this.btnEnr.TabIndex = 4;
            this.btnEnr.Text = "Ajouter";
            this.btnEnr.UseVisualStyleBackColor = false;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.Controls.Add(this.lblAdresse);
            this.pnlMid.Controls.Add(this.lblNom);
            this.pnlMid.Location = new System.Drawing.Point(12, 78);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(265, 147);
            this.pnlMid.TabIndex = 5;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(7, 86);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 17);
            this.lblAdresse.TabIndex = 1;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // Form_AM_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 277);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AM_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
    }
}