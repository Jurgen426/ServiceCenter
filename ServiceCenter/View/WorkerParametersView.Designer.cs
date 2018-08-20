namespace ServiceCenter.View
{
    partial class WorkerParametersView
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
            this.labelWorkerName = new System.Windows.Forms.Label();
            this.labelWorkwrSurName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelWorkerPhonenumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWorkerName
            // 
            this.labelWorkerName.AutoSize = true;
            this.labelWorkerName.Location = new System.Drawing.Point(12, 51);
            this.labelWorkerName.Name = "labelWorkerName";
            this.labelWorkerName.Size = new System.Drawing.Size(29, 13);
            this.labelWorkerName.TabIndex = 0;
            this.labelWorkerName.Text = "Имя";
            // 
            // labelWorkwrSurName
            // 
            this.labelWorkwrSurName.AutoSize = true;
            this.labelWorkwrSurName.Location = new System.Drawing.Point(12, 85);
            this.labelWorkwrSurName.Name = "labelWorkwrSurName";
            this.labelWorkwrSurName.Size = new System.Drawing.Size(56, 13);
            this.labelWorkwrSurName.TabIndex = 1;
            this.labelWorkwrSurName.Text = "Фамилия";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(12, 153);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Должность";
            // 
            // labelWorkerPhonenumber
            // 
            this.labelWorkerPhonenumber.AutoSize = true;
            this.labelWorkerPhonenumber.Location = new System.Drawing.Point(12, 119);
            this.labelWorkerPhonenumber.Name = "labelWorkerPhonenumber";
            this.labelWorkerPhonenumber.Size = new System.Drawing.Size(93, 13);
            this.labelWorkerPhonenumber.TabIndex = 3;
            this.labelWorkerPhonenumber.Text = "Номер телефона";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(147, 82);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.Location = new System.Drawing.Point(147, 113);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhonenumber.TabIndex = 6;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(147, 144);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 183);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnButtonSaveNewWorkerClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 26);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(147, 19);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // WorkerParametersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 236);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxPhonenumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelWorkerPhonenumber);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelWorkwrSurName);
            this.Controls.Add(this.labelWorkerName);
            this.Name = "WorkerParametersView";
            this.Text = "WorkerParametersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkerName;
        private System.Windows.Forms.Label labelWorkwrSurName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelWorkerPhonenumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
    }
}