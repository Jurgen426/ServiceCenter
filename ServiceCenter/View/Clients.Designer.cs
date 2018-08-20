namespace ServiceCenter.View
{
    partial class Clients
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
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.headerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPhonenumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Location = new System.Drawing.Point(186, 256);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateClient.TabIndex = 1;
            this.buttonCreateClient.Text = "Создать";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.OnButtonCreateClientClick);
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(12, 256);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectClient.TabIndex = 2;
            this.buttonSelectClient.Text = "Выбрать";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.OnButtonSelectClient);
            // 
            // listViewClients
            // 
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerName,
            this.headerSurname,
            this.headerPhonenumbers,
            this.headerNotes});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.Location = new System.Drawing.Point(12, 12);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(597, 238);
            this.listViewClients.TabIndex = 1;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
            // 
            // headerId
            // 
            this.headerId.Text = "Id";
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            this.headerName.Width = 80;
            // 
            // headerSurname
            // 
            this.headerSurname.Text = "Surname";
            this.headerSurname.Width = 80;
            // 
            // headerPhonenumbers
            // 
            this.headerPhonenumbers.Text = "Phonenumbers";
            this.headerPhonenumbers.Width = 200;
            // 
            // headerNotes
            // 
            this.headerNotes.Text = "Notes";
            this.headerNotes.Width = 200;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(360, 256);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.OnButtonChangeClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(534, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 291);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.listViewClients);
            this.Controls.Add(this.buttonSelectClient);
            this.Controls.Add(this.buttonCreateClient);
            this.Name = "Clients";
            this.Text = "Clients";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonSelectClient;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerSurname;
        private System.Windows.Forms.ColumnHeader headerPhonenumbers;
        private System.Windows.Forms.ColumnHeader headerNotes;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColumnHeader headerId;
    }
}