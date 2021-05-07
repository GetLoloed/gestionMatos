
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
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
            this.pnlTop.Size = new System.Drawing.Size(291, 68);
            this.pnlTop.TabIndex = 2;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAM.ForeColor = System.Drawing.Color.White;
            this.lblAM.Location = new System.Drawing.Point(17, 22);
            this.lblAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(144, 25);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Ajouts d\'un site";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(10, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(248, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(10, 137);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(248, 20);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(10, 183);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(248, 20);
            this.txtVille.TabIndex = 5;
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(72, 326);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(152, 23);
            this.btnEnr.TabIndex = 7;
            this.btnEnr.Text = "Ajouter";
            this.btnEnr.UseVisualStyleBackColor = true;
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
            this.pnlMid.Location = new System.Drawing.Point(12, 75);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(267, 224);
            this.pnlMid.TabIndex = 8;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom :";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(7, 71);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(69, 13);
            this.lblCp.TabIndex = 10;
            this.lblCp.Text = "Code postal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adresse :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(7, 167);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 12;
            this.lblVille.Text = "Ville :";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(10, 87);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(249, 20);
            this.txtCp.TabIndex = 13;
            // 
            // Form_AM_Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 366);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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