namespace CaMarcheOuPas
{
    partial class SettingSMTP
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
            this.labelSMTP = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSSL = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSMTP
            // 
            this.labelSMTP.AutoSize = true;
            this.labelSMTP.Location = new System.Drawing.Point(43, 9);
            this.labelSMTP.Name = "labelSMTP";
            this.labelSMTP.Size = new System.Drawing.Size(102, 13);
            this.labelSMTP.TabIndex = 0;
            this.labelSMTP.Text = "Configuration SMTP";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(15, 56);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(178, 20);
            this.textMail.TabIndex = 1;
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(15, 156);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(181, 20);
            this.textHost.TabIndex = 3;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(15, 195);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(71, 20);
            this.textPort.TabIndex = 4;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(15, 94);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(100, 20);
            this.textPwd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Host:";
            // 
            // checkSSL
            // 
            this.checkSSL.AutoSize = true;
            this.checkSSL.Location = new System.Drawing.Point(15, 120);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(46, 17);
            this.checkSSL.TabIndex = 11;
            this.checkSSL.Text = "SSL";
            this.checkSSL.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(-2, 242);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(227, 36);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(-2, 276);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(227, 36);
            this.buttonLeave.TabIndex = 13;
            this.buttonLeave.Text = "Annuler";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // SettingSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 312);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkSSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.labelSMTP);
            this.Name = "SettingSMTP";
            this.Text = "Configuration SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSMTP;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkSSL;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLeave;
    }
}