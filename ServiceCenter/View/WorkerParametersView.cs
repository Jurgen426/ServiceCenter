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
    public partial class WorkerParametersView : Form
    {
        public event Action<Worker> SaveWorker;

        public WorkerParametersView()
        {
            InitializeComponent();
            FillPositions();
            SetDafaultValues();

        }

        public void ShowView(Worker worker)
        {
            textBoxName.Text = worker.Name;
            textBoxSurname.Text = worker.Surname;
            textBoxPhonenumber.Text = worker.PhoneNumbers;
            comboBoxPosition.SelectedIndex = (int)worker.Position;
            textBoxId.Text = worker.Id.ToString();
            this.ShowDialog();

        }

        private void FillPositions()
        {
            comboBoxPosition.Items.AddRange(Enum.GetNames(typeof(Position)));
        }

        private void SetDafaultValues()
        {
            textBoxName.Text = "name";
            textBoxSurname.Text = "Surname";
            textBoxPhonenumber.Text = "123456789";
            comboBoxPosition.SelectedIndex = 0;
        }

        private void OnButtonSaveNewWorkerClick(object sender, EventArgs e)
        {
            Worker currentWorker = new Worker();
            currentWorker.Name = textBoxName.Text;
            currentWorker.Surname = textBoxSurname.Text;
            currentWorker.Position = (Position)comboBoxPosition.SelectedIndex;
            currentWorker.PhoneNumbers = textBoxPhonenumber.Text;
            if (!String.IsNullOrEmpty(textBoxId.Text))
            {
                currentWorker.Id = Int32.Parse(textBoxId.Text);
            }


            if (SaveWorker != null)
            {
                SaveWorker(currentWorker);
                SetDafaultValues();
            }

        }

        


    }
}
