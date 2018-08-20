using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceCenterLibrary;

namespace ServiceCenter.View
{
    public partial class NewOrder : Form
    {
        
        public event Action SelectClientAction;
        public event Action<Dictionary<string, string>> SaveOrderAction;

        public NewOrder()
        {
            InitializeComponent();
        }

        public void SetOrderNumber(int number)
        { 
            textBoxOrderNumber.Text = number.ToString();
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
            
            textBoxClient.Text = client.Name+" "+client.Surname;
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("deviceMark", textBoxDeviceMark.Text);
            keyValues.Add("deviceModel", textBoxDeviceModel.Text);
            keyValues.Add("description", textBoxMulfunctionDescription.Text);
            if (SaveOrderAction!=null)
            {
                SaveOrderAction(keyValues);
            }
        }
        
        

        public void SetDefaultValues()
        {
            textBoxClient.Text = "";
            textBoxDeviceMark.Text = "";
            textBoxDeviceModel.Text = "";
            textBoxMulfunctionDescription.Text = "";
        }
    }
}
