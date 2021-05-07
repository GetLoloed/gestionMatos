
namespace GestionMatos.Forms.FormAjouModif
{
    partial class Form_AM_Interventions
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
            this.cbMateriel = new System.Windows.Forms.ComboBox();
            this.txtCom = new System.Windows.Forms.RichTextBox();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpInter = new System.Windows.Forms.DateTimePicker();
            this.gbMat = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnr = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.pnlTop.Controls.Add(this.lblAM);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(275, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAM.ForeColor = System.Drawing.Color.White;
            this.lblAM.Location = new System.Drawing.Point(13, 18);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(250, 25);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Programmation Intervention";
            // 
            // cbMateriel
            // 
            this.cbMateriel.FormattingEnabled = true;
            this.cbMateriel.Location = new System.Drawing.Point(6, 22);
            this.cbMateriel.Name = "cbMateriel";
            this.cbMateriel.Size = new System.Drawing.Size(227, 24);
            this.cbMateriel.TabIndex = 1;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(6, 22);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(231, 202);
            this.txtCom.TabIndex = 3;
            this.txtCom.Text = "";
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.Controls.Add(this.groupBox1);
            this.pnlMid.Controls.Add(this.gbMat);
            this.pnlMid.Controls.Add(this.groupBox2);
            this.pnlMid.Location = new System.Drawing.Point(12, 61);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(251, 366);
            this.pnlMid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpInter);
            this.groupBox1.Location = new System.Drawing.Point(3, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date d\'intervention";
            // 
            // dtpInter
            // 
            this.dtpInter.CustomFormat = "yyyy-MM-dd";
            this.dtpInter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInter.Location = new System.Drawing.Point(6, 22);
            this.dtpInter.Name = "dtpInter";
            this.dtpInter.Size = new System.Drawing.Size(227, 23);
            this.dtpInter.TabIndex = 0;
            // 
            // gbMat
            // 
            this.gbMat.Controls.Add(this.cbMateriel);
            this.gbMat.Location = new System.Drawing.Point(3, 3);
            this.gbMat.Name = "gbMat";
            this.gbMat.Size = new System.Drawing.Size(243, 59);
            this.gbMat.TabIndex = 4;
            this.gbMat.TabStop = false;
            this.gbMat.Text = "Materiel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCom);
            this.groupBox2.Location = new System.Drawing.Point(3, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commentaire ";
            // 
            // btnEnr
            // 
            this.btnEnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.btnEnr.ForeColor = System.Drawing.Color.White;
            this.btnEnr.Location = new System.Drawing.Point(15, 433);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(243, 26);
            this.btnEnr.TabIndex = 5;
            this.btnEnr.Text = "Programmer";
            this.btnEnr.UseVisualStyleBackColor = false;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // Form_AM_Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 465);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AM_Interventions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interventions";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbMat.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cbMateriel;
        private System.Windows.Forms.RichTextBox txtCom;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.GroupBox gbMat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpInter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.Label lblAM;
    }
}