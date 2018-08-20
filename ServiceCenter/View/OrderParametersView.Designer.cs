namespace ServiceCenter.View
{
    partial class OrderParametersView
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
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelDeviceModel = new System.Windows.Forms.Label();
            this.textBoxDeviceMark = new System.Windows.Forms.TextBox();
            this.textBoxDeviceModel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimeOfAcceptance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCostOfRepair = new System.Windows.Forms.TextBox();
            this.buttonSelectRemonter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxTimeOfReturn = new System.Windows.Forms.TextBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxWorkerId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(20, 12);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(41, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(20, 72);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // labelDeviceMark
            // 
            this.labelDeviceMark.AutoSize = true;
            this.labelDeviceMark.Location = new System.Drawing.Point(24, 22);
            this.labelDeviceMark.Name = "labelDeviceMark";
            this.labelDeviceMark.Size = new System.Drawing.Size(86, 13);
            this.labelDeviceMark.TabIndex = 2;
            this.labelDeviceMark.Text = "Производитель";
            // 
            // labelMulfunction
            // 
            this.labelMulfunction.AutoSize = true;
            this.labelMulfunction.Location = new System.Drawing.Point(20, 213);
            this.labelMulfunction.Name = "labelMulfunction";
            this.labelMulfunction.Size = new System.Drawing.Size(86, 13);
            this.labelMulfunction.TabIndex = 3;
            this.labelMulfunction.Text = "Неисправность\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonSelectClientClick);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(193, 72);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(126, 20);
            this.textBoxClient.TabIndex = 7;
            // 
            // textBoxMulfunctionDescription
            // 
            this.textBoxMulfunctionDescription.Location = new System.Drawing.Point(147, 210);
            this.textBoxMulfunctionDescription.Multiline = true;
            this.textBoxMulfunctionDescription.Name = "textBoxMulfunctionDescription";
            this.textBoxMulfunctionDescription.Size = new System.Drawing.Size(253, 74);
            this.textBoxMulfunctionDescription.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(162, 529);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(147, 12);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.ReadOnly = true;
            this.textBoxOrderId.Size = new System.Drawing.Size(253, 20);
            this.textBoxOrderId.TabIndex = 4;
            // 
            // labelDeviceModel
            // 
            this.labelDeviceModel.AutoSize = true;
            this.labelDeviceModel.Location = new System.Drawing.Point(64, 58);
            this.labelDeviceModel.Name = "labelDeviceModel";
            this.labelDeviceModel.Size = new System.Drawing.Size(46, 13);
            this.labelDeviceModel.TabIndex = 10;
            this.labelDeviceModel.Text = "Модель";
            // 
            // textBoxDeviceMark
            // 
            this.textBoxDeviceMark.Location = new System.Drawing.Point(132, 19);
            this.textBoxDeviceMark.Name = "textBoxDeviceMark";
            this.textBoxDeviceMark.Size = new System.Drawing.Size(240, 20);
            this.textBoxDeviceMark.TabIndex = 11;
            // 
            // textBoxDeviceModel
            // 
            this.textBoxDeviceModel.Location = new System.Drawing.Point(132, 58);
            this.textBoxDeviceModel.Name = "textBoxDeviceModel";
            this.textBoxDeviceModel.Size = new System.Drawing.Size(240, 20);
            this.textBoxDeviceModel.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDeviceModel);
            this.groupBox1.Controls.Add(this.labelDeviceModel);
            this.groupBox1.Controls.Add(this.textBoxDeviceMark);
            this.groupBox1.Controls.Add(this.labelDeviceMark);
            this.groupBox1.Location = new System.Drawing.Point(20, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 84);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Устройство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Время приема";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Время выдачи";
            // 
            // textBoxTimeOfAcceptance
            // 
            this.textBoxTimeOfAcceptance.Location = new System.Drawing.Point(147, 296);
            this.textBoxTimeOfAcceptance.Name = "textBoxTimeOfAcceptance";
            this.textBoxTimeOfAcceptance.Size = new System.Drawing.Size(253, 20);
            this.textBoxTimeOfAcceptance.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ремонтер";
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(193, 357);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(126, 20);
            this.textBoxWorker.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Комент. исполнителя";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(147, 390);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(251, 68);
            this.textBoxComment.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Стоимость ремонта";
            // 
            // textBoxCostOfRepair
            // 
            this.textBoxCostOfRepair.Location = new System.Drawing.Point(147, 474);
            this.textBoxCostOfRepair.Name = "textBoxCostOfRepair";
            this.textBoxCostOfRepair.Size = new System.Drawing.Size(251, 20);
            this.textBoxCostOfRepair.TabIndex = 23;
            // 
            // buttonSelectRemonter
            // 
            this.buttonSelectRemonter.Location = new System.Drawing.Point(325, 355);
            this.buttonSelectRemonter.Name = "buttonSelectRemonter";
            this.buttonSelectRemonter.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectRemonter.TabIndex = 24;
            this.buttonSelectRemonter.Text = "Выбрать";
            this.buttonSelectRemonter.UseVisualStyleBackColor = true;
            this.buttonSelectRemonter.Click += new System.EventHandler(this.OnButtonSelectRemonterClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(147, 38);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(253, 21);
            this.comboBoxStatus.TabIndex = 26;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.OnOrderStatusChanged);
            // 
            // textBoxTimeOfReturn
            // 
            this.textBoxTimeOfReturn.Location = new System.Drawing.Point(147, 324);
            this.textBoxTimeOfReturn.Name = "textBoxTimeOfReturn";
            this.textBoxTimeOfReturn.Size = new System.Drawing.Size(253, 20);
            this.textBoxTimeOfReturn.TabIndex = 27;
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Enabled = false;
            this.textBoxClientId.Location = new System.Drawing.Point(147, 72);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(40, 20);
            this.textBoxClientId.TabIndex = 28;
            // 
            // textBoxWorkerId
            // 
            this.textBoxWorkerId.Enabled = false;
            this.textBoxWorkerId.Location = new System.Drawing.Point(147, 358);
            this.textBoxWorkerId.Name = "textBoxWorkerId";
            this.textBoxWorkerId.Size = new System.Drawing.Size(40, 20);
            this.textBoxWorkerId.TabIndex = 29;
            // 
            // OrderParametersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 588);
            this.Controls.Add(this.textBoxWorkerId);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.textBoxTimeOfReturn);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSelectRemonter);
            this.Controls.Add(this.textBoxCostOfRepair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeOfAcceptance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMulfunctionDescription);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.labelMulfunction);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelNumber);
            this.Name = "OrderParametersView";
            this.Text = "NewOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelDeviceModel;
        private System.Windows.Forms.TextBox textBoxDeviceMark;
        private System.Windows.Forms.TextBox textBoxDeviceModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimeOfAcceptance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCostOfRepair;
        private System.Windows.Forms.Button buttonSelectRemonter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxTimeOfReturn;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxWorkerId;
    }
}