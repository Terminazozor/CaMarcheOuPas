namespace CaMarcheOuPas
{
    partial class MachineSettings
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
            this.textNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textIntervalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(12, 24);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(150, 20);
            this.textNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse IP:";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(12, 68);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(150, 20);
            this.textIP.TabIndex = 3;
            // 
            // textIntervalle
            // 
            this.textIntervalle.Location = new System.Drawing.Point(12, 109);
            this.textIntervalle.Name = "textIntervalle";
            this.textIntervalle.Size = new System.Drawing.Size(150, 20);
            this.textIntervalle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intervalle :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MachineSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIntervalle);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNom);
            this.Name = "MachineSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textIntervalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}