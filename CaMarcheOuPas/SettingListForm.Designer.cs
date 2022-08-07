namespace CaMarcheOuPas
{
    partial class SettingListForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listMachine = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(216, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 37);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(216, 64);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 37);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listMachine
            // 
            this.listMachine.FormattingEnabled = true;
            this.listMachine.Location = new System.Drawing.Point(6, 5);
            this.listMachine.Name = "listMachine";
            this.listMachine.Size = new System.Drawing.Size(204, 368);
            this.listMachine.TabIndex = 3;
            // 
            // SettingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 375);
            this.Controls.Add(this.listMachine);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Name = "SettingListForm";
            this.Text = "SettingListForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox listMachine;
    }
}