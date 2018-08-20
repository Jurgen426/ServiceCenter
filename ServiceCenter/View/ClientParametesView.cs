using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceCenter.Model;
using ServiceCenterLibrary;

namespace ServiceCenter.View
{
    public partial class ClientParametesView : Form
    {
        
        // Событие, возникающее при сохранении клиента
        public event Action<Client> SaveClientAction;

        public ClientParametesView()
        {
            InitializeComponent();
            SetDafaultValues();
        }

        public void ShowView(Client client)
        {
            textBoxClientName.Text = client.Name;
            textBoxClientSurname.Text = client.Surname;
            textBoxClientPhonenumber.Text = client.PhoneNumbers;
            textBoxClientNotes.Text = client.Notes;
            textBoxId.Text = client.Id.ToString();
            this.ShowDialog();

        }

        

        private void SetDafaultValues()
        {
            textBoxClientName.Text = "Name";
            textBoxClientSurname.Text = "Surname";
            textBoxClientPhonenumber.Text = "123456789";
            textBoxClientNotes.Text = "Just client";
            textBoxId.Text = "";
            
        }


        
       
        private void OnButtonSaveNewClientClick(object sender, EventArgs e)
        {
            Client currentClient = new Client();
            currentClient.Name = textBoxClientName.Text;
            currentClient.Surname = textBoxClientSurname.Text;
            currentClient.PhoneNumbers = textBoxClientPhonenumber.Text;
            currentClient.Notes = textBoxClientNotes.Text;
            if (!String.IsNullOrEmpty(textBoxId.Text))
            {
                currentClient.Id = Int32.Parse(textBoxId.Text);
            }
            

            if (SaveClientAction!=null)
            {
                SaveClientAction(currentClient);
                SetDafaultValues();
            }

        }
    }
}
