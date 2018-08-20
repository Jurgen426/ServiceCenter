namespace ServiceCenter.View
{
    partial class ClientParametesView
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientSurname = new System.Windows.Forms.TextBox();
            this.textBoxClientPhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxClientNotes = new System.Windows.Forms.TextBox();
            this.buttonSaveNewClient = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(19, 82);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Location = new System.Drawing.Point(19, 115);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhonenumber.TabIndex = 2;
            this.labelPhonenumber.Text = "Phonenumbers";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(19, 148);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 3;
            this.labelNotes.Text = "Notes";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(117, 46);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(223, 20);
            this.textBoxClientName.TabIndex = 4;
            // 
            // textBoxClientSurname
            // 
            this.textBoxClientSurname.Location = new System.Drawing.Point(117, 81);
            this.textBoxClientSurname.Name = "textBoxClientSurname";
            this.textBoxClientSurname.Size = new System.Drawing.Size(223, 20);
            this.textBoxClientSurname.TabIndex = 5;
            // 
            // textBoxClientPhonenumber
            // 
            this.textBoxClientPhonenumber.Location = new System.Drawing.Point(117, 114);
            this.textBoxClientPhonenumber.Name = "textBoxClientPhonenumber";
            this.textBoxClientPhonenumber.Size = new System.Drawing.Size(223, 20);
            this.textBoxClientPhonenumber.TabIndex = 6;
            // 
            // textBoxClientNotes
            // 
            this.textBoxClientNotes.Location = new System.Drawing.Point(117, 147);
            this.textBoxClientNotes.Multiline = true;
            this.textBoxClientNotes.Name = "textBoxClientNotes";
            this.textBoxClientNotes.Size = new System.Drawing.Size(223, 82);
            this.textBoxClientNotes.TabIndex = 7;
            // 
            // buttonSaveNewClient
            // 
            this.buttonSaveNewClient.Location = new System.Drawing.Point(137, 235);
            this.buttonSaveNewClient.Name = "buttonSaveNewClient";
            this.buttonSaveNewClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNewClient.TabIndex = 8;
            this.buttonSaveNewClient.Text = "Сохранить";
            this.buttonSaveNewClient.UseVisualStyleBackColor = true;
            this.buttonSaveNewClient.Click += new System.EventHandler(this.OnButtonSaveNewClientClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(19, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(117, 16);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(223, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // ClientParametesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 270);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSaveNewClient);
            this.Controls.Add(this.textBoxClientNotes);
            this.Controls.Add(this.textBoxClientPhonenumber);
            this.Controls.Add(this.textBoxClientSurname);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelPhonenumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "ClientParametesView";
            this.Text = "NewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientSurname;
        private System.Windows.Forms.TextBox textBoxClientPhonenumber;
        private System.Windows.Forms.TextBox textBoxClientNotes;
        private System.Windows.Forms.Button buttonSaveNewClient;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
    }
}