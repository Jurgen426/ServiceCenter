using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ServiceCenter.Model;

namespace ServiceCenter.View
{
     

    public partial class MainWindow : Form
    {
        public event Action CreateOrder;
        public event Action EditeOrders;
        public event Action ShowWorkers;
        public event Action ShowClients;

        private OrdersModel oModel;


        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        public MainWindow(OrdersModel ordersModel)
        {
            InitializeComponent();
            this.oModel = ordersModel;
            Subscribe();
            ShowCountOfOrders();
            ShowCountOfNewOrders();
        }


        private void OnCreateOrderMenuItemClick(object sender, EventArgs e)
        {
            if (CreateOrder != null)
            {
                CreateOrder();
            }
        }

        private void OnWorkersMenuItemClick(object sender, EventArgs e)
        {
            //ShowWorkers?.Invoke(); //упрощенный вызов события
            if (ShowWorkers != null)
            {
                ShowWorkers();
            }
        }

        private void OnClientsMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowClients != null)
            {
                ShowClients();
            }
            //ShowClients?.Invoke();
        }

        private void OnEditOrdersMenuItemlick(object sender, EventArgs e)
        {
            if (EditeOrders != null)
            {
                EditeOrders();
            }
            //EditeOrders?.Invoke();
        }

        public void ShowCountOfOrders()
        {
            int count = oModel.GetOrdersCount();
            textBoxCountOfOrders.Text = count.ToString();
        }

        public void ShowCountOfNewOrders()
        {
            int count = oModel.GetNewOrderCount();
            textBoxCountOfNewOrders.Text = count.ToString();
        }


        private void Subscribe()
        {
            oModel.ModelChanged += ShowCountOfOrders;
            oModel.ModelChanged += ShowCountOfNewOrders;

        }

        private void Unsubscribe()
        {
            oModel.ModelChanged -= ShowCountOfOrders;
            oModel.ModelChanged -= ShowCountOfNewOrders;
        }


    }
}
