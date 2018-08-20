using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ServiceCenterLibrary;

namespace ServiceCenter.View
{
    public partial class Orders : Form
    {

        public event Action<int> ModifyOrder;

        public Orders(List<Order> orders)
        {
            InitializeComponent();
            InitializeList(orders);
        }

        private void InitializeList(List<Order> orders)
        {
            foreach (var o in orders)
            {
                AddOrderToList(o);
            }
        }
        private void AddOrderToList(Order order)
        {
            ListViewItem item = listViewOrders.Items.Add(order.Id.ToString());
            item.SubItems.Add(order.MyStatus.ToString());
            string device = "";
            if (order.MyDevice != null)
            {
                 device = String.Concat(order.MyDevice.Mark.ToString(), " ", order.MyDevice.Model.ToString());
            }
            //string device = String.Concat(order.MyDevice?.Mark.ToString(), " ", order.MyDevice?.Model.ToString());
            item.SubItems.Add(device);
            string client = "";
            if (order.MyClient!= null)
            {
                client = String.Concat(order.MyClient.Surname, " ", order.MyClient.Name);
            }
            
            //string client = String.Concat(order.MyClient?.Surname," ", order.MyClient?.Name);
            item.SubItems.Add(client);
            string remonter = "";
            if (order.Repairer!=null)
            {
                remonter = String.Concat(order.Repairer.Surname, " ", order.Repairer.Name);
            }

            //string remonter = String.Concat(order.Repairer?.Surname, " ", order.Repairer?.Name);
            
            item.SubItems.Add(remonter);
            item.SubItems.Add(order.TimeOfAcceptance.ToShortDateString());
            item.SubItems.Add(order.TimeOfReturn.ToShortDateString());
            item.SubItems.Add(order.CostOfRepair.ToString());
        }



        public void RefreshList(List<Order> orders)
        {
            listViewOrders.Items.Clear();
            foreach (var o in orders)
            {
                AddOrderToList(o);


            }
        }

        private void OnListViewOrdersDoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(listViewOrders.SelectedItems[0].SubItems[0].Text); //парсим ид клиента из выбранной строки и нулевого столбца
            if (ModifyOrder != null)
            {
                ModifyOrder(id);
            }
        }
    }
}
