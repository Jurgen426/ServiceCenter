namespace ServiceCenter.View
{
    partial class Orders
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
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.headerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerRemonter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAcceptance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerStatus,
            this.headerDevice,
            this.headerClient,
            this.headerRemonter,
            this.headerAcceptance,
            this.headerReturn,
            this.headerCost});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(12, 12);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(720, 512);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.DoubleClick += new System.EventHandler(this.OnListViewOrdersDoubleClick);
            // 
            // headerId
            // 
            this.headerId.Text = "Id";
            this.headerId.Width = 30;
            // 
            // headerStatus
            // 
            this.headerStatus.Text = "Status";
            // 
            // headerDevice
            // 
            this.headerDevice.Text = "Device";
            this.headerDevice.Width = 120;
            // 
            // headerClient
            // 
            this.headerClient.Text = "Client";
            this.headerClient.Width = 100;
            // 
            // headerRemonter
            // 
            this.headerRemonter.Text = "Remonter";
            this.headerRemonter.Width = 100;
            // 
            // headerAcceptance
            // 
            this.headerAcceptance.Text = "TimeOfAcceptance";
            this.headerAcceptance.Width = 120;
            // 
            // headerReturn
            // 
            this.headerReturn.Text = "TimeOfReturn";
            this.headerReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.headerReturn.Width = 120;
            // 
            // headerCost
            // 
            this.headerCost.Text = "Cost";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 582);
            this.Controls.Add(this.listViewOrders);
            this.Name = "Orders";
            this.Text = "OrderParametersView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader headerId;
        private System.Windows.Forms.ColumnHeader headerStatus;
        private System.Windows.Forms.ColumnHeader headerDevice;
        private System.Windows.Forms.ColumnHeader headerClient;
        private System.Windows.Forms.ColumnHeader headerRemonter;
        private System.Windows.Forms.ColumnHeader headerAcceptance;
        private System.Windows.Forms.ColumnHeader headerReturn;
        private System.Windows.Forms.ColumnHeader headerCost;
    }
}