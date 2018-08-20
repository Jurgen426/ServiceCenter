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
    public partial class Workers : Form
    {
        public event Action CreateWorker;
        public event Action<Worker> SelectWorker;
        public event Action<int> DeleteWorker;
        public event Action<int> ModifyWorker;

        public Workers(List<Worker> workers)
        {
            InitializeComponent();
            RefreshList(workers);
        }

        

        private void AddWorkerToList(Worker worker)
        {
            ListViewItem item = listViewWorkers.Items.Add(worker.Id.ToString());
            item.SubItems.Add(worker.Name);
            item.SubItems.Add(worker.Surname);
            item.SubItems.Add(worker.PhoneNumbers);
            item.SubItems.Add(worker.Position.ToString());

        }

        public void RefreshList(List<Worker> workers)
        {
            listViewWorkers.Items.Clear();
            foreach (var w in workers)
            {
                AddWorkerToList(w);
            }
        }

        private void OnButtonCreateClick(object sender, EventArgs e)
        {
            if (CreateWorker != null)
            {
                CreateWorker();
            }

        }

       
        

        
        

        private void OnButtonSelectClick(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selected = listViewWorkers.SelectedIndices;
            int index = selected[0];
            int id = int.Parse(listViewWorkers.Items[index].SubItems[0].Text);
            string name = listViewWorkers.Items[index].SubItems[1].Text;
            string surname = listViewWorkers.Items[index].SubItems[2].Text;
            string phones = listViewWorkers.Items[index].SubItems[3].Text;
            string position = listViewWorkers.Items[index].SubItems[4].Text;
            Worker tmpWorker = new Worker();
            tmpWorker.Id = id;
            tmpWorker.Name = name;
            tmpWorker.Surname = surname;
            tmpWorker.PhoneNumbers = phones;
            tmpWorker.Position = (Position)Enum.Parse(typeof(Position), position); //как упростить?
            if (SelectWorker != null)
            {
                SelectWorker(tmpWorker);
            }

        }

        //удаление сотрудника
        private void OnButtonDeleteClick(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                int id = int.Parse(listViewWorkers.SelectedItems[0].SubItems[0].Text); //парсим ид клиента из выбранной строки и нулевого столбца
                if (DeleteWorker != null)
                {
                    DeleteWorker(id);
                }
            }
        }

        ////изменение клиента
        private void OnButtonChangeClick(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count != 0)
            {
                int id = int.Parse(listViewWorkers.SelectedItems[0].SubItems[0].Text); //парсим ид клиента из выбранной строки и нулевого столбца
                if (ModifyWorker != null)
                {
                    ModifyWorker(id);
                }
            }
        }
    }
}
