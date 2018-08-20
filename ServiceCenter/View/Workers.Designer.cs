namespace ServiceCenter.View
{
    partial class Workers
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
            this.listViewWorkers = new System.Windows.Forms.ListView();
            this.headerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPhonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewWorkers
            // 
            this.listViewWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerName,
            this.headerSurname,
            this.headerPhonenumber,
            this.headerPosition});
            this.listViewWorkers.FullRowSelect = true;
            this.listViewWorkers.Location = new System.Drawing.Point(12, 12);
            this.listViewWorkers.MultiSelect = false;
            this.listViewWorkers.Name = "listViewWorkers";
            this.listViewWorkers.Size = new System.Drawing.Size(499, 259);
            this.listViewWorkers.TabIndex = 0;
            this.listViewWorkers.UseCompatibleStateImageBehavior = false;
            this.listViewWorkers.View = System.Windows.Forms.View.Details;
            // 
            // headerId
            // 
            this.headerId.Text = "Id";
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            this.headerName.Width = 100;
            // 
            // headerSurname
            // 
            this.headerSurname.Text = "Surname";
            this.headerSurname.Width = 100;
            // 
            // headerPhonenumber
            // 
            this.headerPhonenumber.Text = "Phonenumber";
            this.headerPhonenumber.Width = 150;
            // 
            // headerPosition
            // 
            this.headerPosition.Text = "Position";
            this.headerPosition.Width = 100;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(423, 287);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(286, 287);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.OnButtonChangeClick);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 287);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.OnButtonSelectClick);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(149, 287);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.OnButtonCreateClick);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 334);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listViewWorkers);
            this.Name = "Workers";
            this.Text = "Workers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewWorkers;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerSurname;
        private System.Windows.Forms.ColumnHeader headerPhonenumber;
        private System.Windows.Forms.ColumnHeader headerPosition;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ColumnHeader headerId;
    }
}