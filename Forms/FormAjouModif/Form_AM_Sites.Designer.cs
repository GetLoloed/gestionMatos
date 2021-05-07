
namespace GestionMatos.Forms.FormAjouModif
{
    partial class Form_AM_Sites
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
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnEnr = new System.Windows.Forms.Button();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
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
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(388, 84);
            this.pnlTop.TabIndex = 2;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAM.ForeColor = System.Drawing.Color.White;
            this.lblAM.Location = new System.Drawing.Point(23, 27);
            this.lblAM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(144, 25);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Ajouts d\'un site";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(13, 52);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(329, 23);
            this.txtNom.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(13, 169);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(329, 23);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(13, 225);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(329, 23);
            this.txtVille.TabIndex = 5;
            // 
            // btnEnr
            // 
            this.btnEnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnEnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnr.ForeColor = System.Drawing.Color.White;
            this.btnEnr.Location = new System.Drawing.Point(96, 401);
            this.btnEnr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(203, 28);
            this.btnEnr.TabIndex = 7;
            this.btnEnr.Text = "Ajouter";
            this.btnEnr.UseVisualStyleBackColor = false;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.Controls.Add(this.txtCp);
            this.pnlMid.Controls.Add(this.lblVille);
            this.pnlMid.Controls.Add(this.label3);
            this.pnlMid.Controls.Add(this.txtVille);
            this.pnlMid.Controls.Add(this.lblCp);
            this.pnlMid.Controls.Add(this.lblNom);
            this.pnlMid.Controls.Add(this.txtNom);
            this.pnlMid.Controls.Add(this.txtAdresse);
            this.pnlMid.Location = new System.Drawing.Point(16, 92);
            this.pnlMid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(356, 276);
            this.pnlMid.TabIndex = 8;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(13, 107);
            this.txtCp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(331, 23);
            this.txtCp.TabIndex = 13;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(9, 206);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(42, 17);
            this.lblVille.TabIndex = 12;
            this.lblVille.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adresse :";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(9, 87);
            this.lblCp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(91, 17);
            this.lblCp.TabIndex = 10;
            this.lblCp.Text = "Code postal :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(9, 32);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom :";
            // 
            // Form_AM_Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_AM_Sites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sites";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtCp;
    }
}