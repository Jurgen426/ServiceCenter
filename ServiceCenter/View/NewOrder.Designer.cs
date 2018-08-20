namespace ServiceCenter.View
{
    partial class NewOrder
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDeviceMark = new System.Windows.Forms.Label();
            this.labelMulfunction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxMulfunctionDescription = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelDeviceModel = new System.Windows.Forms.Label();
            this.textBoxDeviceMark = new System.Windows.Forms.TextBox();
            this.textBoxDeviceModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 12);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(41, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 50);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // labelDeviceMark
            // 
            this.labelDeviceMark.AutoSize = true;
            this.labelDeviceMark.Location = new System.Drawing.Point(12, 84);
            this.labelDeviceMark.Name = "labelDeviceMark";
            this.labelDeviceMark.Size = new System.Drawing.Size(86, 13);
            this.labelDeviceMark.TabIndex = 2;
            this.labelDeviceMark.Text = "Производитель";
            // 
            // labelMulfunction
            // 
            this.labelMulfunction.AutoSize = true;
            this.labelMulfunction.Location = new System.Drawing.Point(12, 141);
            this.labelMulfunction.Name = "labelMulfunction";
            this.labelMulfunction.Size = new System.Drawing.Size(137, 13);
            this.labelMulfunction.TabIndex = 3;
            this.labelMulfunction.Text = "Описание неисправности";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonSelectClientClick);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(177, 47);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(172, 20);
            this.textBoxClient.TabIndex = 7;
            // 
            // textBoxMulfunctionDescription
            // 
            this.textBoxMulfunctionDescription.Location = new System.Drawing.Point(177, 141);
            this.textBoxMulfunctionDescription.Multiline = true;
            this.textBoxMulfunctionDescription.Name = "textBoxMulfunctionDescription";
            this.textBoxMulfunctionDescription.Size = new System.Drawing.Size(253, 74);
            this.textBoxMulfunctionDescription.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(177, 12);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(253, 20);
            this.textBoxOrderNumber.TabIndex = 4;
            // 
            // labelDeviceModel
            // 
            this.labelDeviceModel.AutoSize = true;
            this.labelDeviceModel.Location = new System.Drawing.Point(12, 112);
            this.labelDeviceModel.Name = "labelDeviceModel";
            this.labelDeviceModel.Size = new System.Drawing.Size(106, 13);
            this.labelDeviceModel.TabIndex = 10;
            this.labelDeviceModel.Text = "Модель устройства";
            // 
            // textBoxDeviceMark
            // 
            this.textBoxDeviceMark.Location = new System.Drawing.Point(177, 81);
            this.textBoxDeviceMark.Name = "textBoxDeviceMark";
            this.textBoxDeviceMark.Size = new System.Drawing.Size(253, 20);
            this.textBoxDeviceMark.TabIndex = 11;
            // 
            // textBoxDeviceModel
            // 
            this.textBoxDeviceModel.Location = new System.Drawing.Point(177, 112);
            this.textBoxDeviceModel.Name = "textBoxDeviceModel";
            this.textBoxDeviceModel.Size = new System.Drawing.Size(253, 20);
            this.textBoxDeviceModel.TabIndex = 12;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 267);
            this.Controls.Add(this.textBoxDeviceModel);
            this.Controls.Add(this.textBoxDeviceMark);
            this.Controls.Add(this.labelDeviceModel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMulfunctionDescription);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelMulfunction);
            this.Controls.Add(this.labelDeviceMark);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelNumber);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDeviceMark;
        private System.Windows.Forms.Label labelMulfunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxMulfunctionDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelDeviceModel;
        private System.Windows.Forms.TextBox textBoxDeviceMark;
        private System.Windows.Forms.TextBox textBoxDeviceModel;
    }
}