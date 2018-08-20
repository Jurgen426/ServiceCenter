using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceCenterLibrary;
using ServiceCenter.Model;
using ServiceCenter.Controller;

namespace ServiceCenter.View
{
    public partial class OrderParametersView : Form
    {

        ClientController clientController;
        public OrdersModel ordersModel;
        private WorkersModel workersModel;

        public event Action SelectClientAction;
        public event Action SelectRemonterAction;
        public event Action<Order> SaveOrderAction;
        Order currentOrder;

        //public OrderParametersView()
        //{
        //    InitializeComponent();
        //    FillStatus();
        //    currentOrder = new Order();
        //}

        public OrderParametersView(ClientController clientController,OrdersModel ordersModel, WorkersModel workersModel)
        {
            InitializeComponent();
            FillStatus();
            currentOrder = new Order();

            this.clientController = clientController;
            this.ordersModel = ordersModel;
            this.workersModel = workersModel;
            
        }

        public void ShowView(Order order)
        {
            textBoxOrderId.Text = order.Id.ToString();
            comboBoxStatus.SelectedIndex = (int)order.MyStatus;
            if (order.MyClient != null)
            {
                currentOrder.MyClient = order.MyClient;
                ShowClientInForm(order.MyClient);
            }
            else
            {
                textBoxClient.Text = "";
            }
            
            if (order.MyDevice!=null)
            {
                textBoxDeviceMark.Text = order.MyDevice.Mark;
                textBoxDeviceModel.Text = order.MyDevice.Model;
            }
            else
            {
                textBoxDeviceMark.Text = "";
                textBoxDeviceModel.Text = "";
            }
            textBoxMulfunctionDescription.Text = order.Description;
            textBoxTimeOfAcceptance.Text = order.TimeOfAcceptance.ToString("dd MMM yyyy HH:mm");
            textBoxTimeOfReturn.Text = order.TimeOfReturn.ToString("dd MMM yyyy HH:mm");
            if (order.Repairer != null)
            {
                ShowWorkerInForm(order.Repairer);
            }
            textBoxComment.Text = order.RepairmansComment;
            textBoxCostOfRepair.Text = order.CostOfRepair.ToString();

            this.ShowDialog();

        }


        public void SetOrderNumber(int number)
        { 
            textBoxOrderId.Text = number.ToString();
        }
        
        private void OnButtonSelectClientClick(object sender, EventArgs e)
        {
            if (SelectClientAction != null)
            {
                SelectClientAction();//по этому событию должно открываться окно для выбора клиента
            }
        
        }
        public void ShowClientInForm(Client client)
        {
            textBoxClientId.Text = client.Id.ToString();
            textBoxClient.Text = client.Name+" "+client.Surname;
        }
        public void ShowWorkerInForm(Worker worker)
        {
            textBoxWorkerId.Text = worker.Id.ToString();
            textBoxWorker.Text = worker.Name + " " + worker.Surname;
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            currentOrder.Id = int.Parse(textBoxOrderId.Text);
            currentOrder.MyStatus = (OrderStatus)comboBoxStatus.SelectedIndex;

            if (!String.IsNullOrEmpty(textBoxClientId.Text))
            {
                
                currentOrder.MyClient = clientController.GetClient((int.Parse(textBoxClientId.Text)));
                //currentOrder.MyClient = clientsModel.GetClientById((int.Parse(textBoxClientId.Text)));
            }

            currentOrder.MyDevice = new Device();
            currentOrder.MyDevice.Mark = textBoxDeviceMark.Text;
            currentOrder.MyDevice.Model = textBoxDeviceModel.Text;
            currentOrder.Description = textBoxMulfunctionDescription.Text;
            currentOrder.TimeOfAcceptance = new DateTime();

            if (!String.IsNullOrEmpty(textBoxTimeOfAcceptance.Text))
            {
                currentOrder.TimeOfAcceptance = DateTime.Parse(textBoxTimeOfAcceptance.Text);
            }
            else
            {
                currentOrder.TimeOfAcceptance = DateTime.Now;
            }
            if (!String.IsNullOrEmpty( textBoxTimeOfReturn.Text))
            {
                currentOrder.TimeOfReturn = DateTime.Parse(textBoxTimeOfReturn.Text);
            }

            if (!String.IsNullOrEmpty(textBoxWorkerId.Text))
            {
                currentOrder.Repairer = workersModel.GetWorkerById((int.Parse(textBoxWorkerId.Text)));
            }
            currentOrder.RepairmansComment = textBoxComment.Text;
            if (!String.IsNullOrEmpty(textBoxCostOfRepair.Text))
            {
                currentOrder.CostOfRepair = int.Parse(textBoxCostOfRepair.Text);
            }
            

            if (SaveOrderAction!=null)
            {
                SaveOrderAction(currentOrder);
                currentOrder = new Order();
                //так как мыпередаем объект класса как параметр события
                //мы получаем копию ссылки на него и в дальнейшем используя этот метод
                //это влечет за собой изменение не одного объекта всех ранее переданных сюда
                //чтобы этого измежать пересоздаем этот объект
                currentOrder = new Order();

            }
        }
        
        

        public void SetDefaultValues()
        {
            textBoxOrderId.Text = "";
            textBoxClient.Text = "";
            textBoxDeviceMark.Text = "";
            textBoxDeviceModel.Text = "";
            textBoxMulfunctionDescription.Text = "";
            comboBoxStatus.SelectedIndex = 0;
            textBoxTimeOfAcceptance.Text = "";
            

        }

        private void OnButtonSelectRemonterClick(object sender, EventArgs e)
        {
            if (SelectRemonterAction!=null)
            {
                SelectRemonterAction();
            }

            //SelectRemonterAction?.Invoke();
        }

        private void FillStatus()
        {
            comboBoxStatus.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
        }

        private void OnOrderStatusChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedIndex == (int)OrderStatus.Finished)
            {

                textBoxTimeOfReturn.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm");
            }
            else
            {
                textBoxTimeOfReturn.Text =  "";
            }

        }
    }
}
