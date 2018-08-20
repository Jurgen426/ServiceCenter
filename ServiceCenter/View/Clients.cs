using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceCenterLibrary;
using ServiceCenter;

namespace ServiceCenter.View
{
    public partial class Clients : Form
    {
        public event Action CreateClient;
        public event Action<Client> SelectClient;
        public event Action<int> DeleteClient;
        public event Action<int> ModifyClient;

        private int sortColumn = -1;  //переменная для запоминания сортируемого столбца

        public Clients(List<Client> clients)
        {
            InitializeComponent();
            RefreshList(clients);
 
        }

        public void RefreshList(List<Client> clients)  //обновление списка в форме
        {
            listViewClients.Items.Clear();
            for (int i = 0; i < clients.Count; i++)
            {
                AddClientToListbox(clients[i]);
            }
            
        }

        //добавление одного клиента в листбокс на форме
        //не понял как это работает. разобраться.
        private void AddClientToListbox(Client client) 
        {
            ListViewItem item = listViewClients.Items.Add(client.Id.ToString());
            item.SubItems.Add(client.Name);
            item.SubItems.Add(client.Surname);
            item.SubItems.Add(client.PhoneNumbers);
            item.SubItems.Add(client.Notes);
            
        }

        //создание клиента
        private void OnButtonCreateClientClick(object sender, EventArgs e)
        {
            if (CreateClient != null)
            {
                CreateClient();
            }
        }

        //удаление клиента
        private void OnButtonDeleteClick(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count != 0)
            {
                int id = int.Parse(listViewClients.SelectedItems[0].SubItems[0].Text); //парсим ид клиента из выбранной строки и нулевого столбца
                if (DeleteClient != null)
                {
                    DeleteClient(id);
                }
            }
        }

        //изменение клиента
        private void OnButtonChangeClick(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count != 0)
            {
                int id = int.Parse(listViewClients.SelectedItems[0].SubItems[0].Text); //парсим ид клиента из выбранной строки и нулевого столбца
                if (ModifyClient != null)
                {
                    ModifyClient(id);
                }
            }
        }
        
        //выбор клиента
        private void OnButtonSelectClient(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selected = listViewClients.SelectedIndices;
            if (selected.Count > 0)
            {
                int index = selected[0];
                int id = int.Parse(listViewClients.Items[index].SubItems[0].Text);
                string name = listViewClients.Items[index].SubItems[1].Text;
                string surname = listViewClients.Items[index].SubItems[2].Text;
                string phones = listViewClients.Items[index].SubItems[3].Text;
                string notes = listViewClients.Items[index].SubItems[4].Text;
                Client tmpClient = new Client();
                tmpClient.Id = id;
                tmpClient.Name = name;
                tmpClient.Surname = surname;
                tmpClient.PhoneNumbers = phones;
                tmpClient.Notes = notes;
                if (SelectClient != null)
                {
                    SelectClient(tmpClient);
                }
            }
        }

        //сортировка по клику на название столбца
        private void OnColumnClick(object sender, ColumnClickEventArgs e)
        {
            // определяем что кликнули не на том же столбце
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column; // запомнили сортируемый столбец.
                listViewClients.Sorting = SortOrder.Ascending; // установили сортировку по возрастанию как дефолтную
            }
            else
            {
                //переключаем сортировку если кликнули на том же столбце
                if (listViewClients.Sorting == SortOrder.Ascending)
                { listViewClients.Sorting = SortOrder.Descending; }
                else
                { listViewClients.Sorting = SortOrder.Ascending; }
            }
            //указываем кто бужет сортировать
            //передаем в сортировщик индекс столбца и порядок сортировки
            listViewClients.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewClients.Sorting);
        }

      
    }

}
